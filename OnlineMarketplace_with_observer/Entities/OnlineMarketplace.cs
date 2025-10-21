using System;
using System.Collections.Generic;
using System.Linq;
using OnlineMarketplace_with_observer.Enums;
using OnlineMarketplace_with_observer.Interfaces;

namespace OnlineMarketplace_with_observer.Entities
{
    public class OnlineMarketplace
    {
        private Dictionary<EventType, List<Subscriber>> _subscribers;
        private List<Product> Products;
        private List<Offer> Offers;
        private List<Customer> Customers;

        public OnlineMarketplace()
        {
            _subscribers = new Dictionary<EventType, List<Subscriber>>();
            InitializeSubscribersEvents();
            Products = new List<Product>();
            Offers = new List<Offer>();
            Customers = new List<Customer>();
        }

        private void InitializeSubscribersEvents()
        {
            _subscribers.Add(EventType.NEW_PRODUCT, new List<Subscriber>());
            _subscribers.Add(EventType.NEW_OFFER, new List<Subscriber>());
            _subscribers.Add(EventType.JOB_OPENING, new List<Subscriber>());
        }

        public void Subscribe(EventType eventType, Subscriber subscriber)
        {
            if (_subscribers.ContainsKey(eventType))
            {
                _subscribers[eventType].Add(subscriber);
            }
            else
            {
                _subscribers[eventType] = new List<Subscriber> { subscriber };
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            NotifyUsers(product);
        }

        private void NotifyUsers(Product product)
        {
           
            Products.Add(product);
            NotifySubscribers(EventType.NEW_PRODUCT, $"New product is added: {product.GetName()}");

        }

        public void NotifySubscribers(EventType eventType, string message)
        {
            if (_subscribers.ContainsKey(eventType))
            {
                foreach (var subscriber in _subscribers[eventType])
                {
                    subscriber.Notify(message);
                }
            }
        }

        public void AddOffer(Offer offer )
        {
            Offers.Add(offer);
            NotifySubscribers(EventType.NEW_PRODUCT, $"New Offer is added: {offer.GetMessage()}");
        }

        public void AddNewJobOpening(string jobTitle)
        {
            NotifySubscribers(EventType.JOB_OPENING, $"New Job Opening: {jobTitle}");
        }


        public void UnSubscribe(EventType eventType, Subscriber subscriber)
        {
            if (_subscribers.ContainsKey(eventType))
            {
                _subscribers[eventType].Remove(subscriber);
            }
        }
    }
}
