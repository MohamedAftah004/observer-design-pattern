using OnlineMarketplace_with_observer.Entities;
using OnlineMarketplace_with_observer.Interfaces;
using System;
using System.ComponentModel;
using OnlineMarketplace_with_observer.Enums;
using System.Threading.Tasks.Dataflow;
namespace OnlineMarketplace_with_observer
{
    class Program
    {
        static void Main(string[] args)
        {

            OnlineMarketplace onlineMarketplace = new OnlineMarketplace();



            //customers
            Subscriber mohamed = new Customer("Mohamed");
            Subscriber youssef = new Customer("Youssef");
            Subscriber mostafa = new JobFinder("Mostafa");

            //products
            Product laptop = new Product("Laptop", 999.99m);
            Product keyboard = new Product("Keyboard", 49.99m);
            Product monitor = new Product("Monitor", 199.99m);


            //offers
            Offer summerSale = new Offer("Summer Sale: Up to 50% off on selected items!");



            //ading users to marketplace 
            onlineMarketplace.AddProduct(laptop);
            onlineMarketplace.AddProduct(keyboard);


            //subscribing customers -> to new products
            onlineMarketplace.Subscribe(EventType.NEW_PRODUCT, mohamed);
            onlineMarketplace.Subscribe(EventType.NEW_PRODUCT, mohamed);
            onlineMarketplace.Subscribe(EventType.NEW_OFFER, youssef);




            //addig offers
            onlineMarketplace.AddOffer(summerSale);
            
            

            //Jobs
            onlineMarketplace.Subscribe(EventType.JOB_OPENING, mostafa);
            onlineMarketplace.AddNewJobOpening("Senior Developer!");

        }
    }
}