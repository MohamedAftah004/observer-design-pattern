
namespace OnlineMarketplace
{
    public class User
    {
        private string _name;
        private bool _isSubscribedToProducts;
        private bool _isSubscribedToOffers;

        public User(string name, bool isSubscribedToProducts, bool isSubscribedToOffers)
        {
            _name = name;
            _isSubscribedToProducts = isSubscribedToProducts;
            _isSubscribedToOffers = isSubscribedToOffers;
        }


        public string getName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }

        public bool isSubscribedToProducts()
        {
            return _isSubscribedToProducts;
        }

        public bool isSubscribedToOffers()
        {
            return _isSubscribedToOffers;
        }


        public void notify(Product product)
        {
            Console.WriteLine($"Notification to {_name}: New product added - {product.getName()} at price {product.getPrice()}");
        }

        public void notify(Offer offer)
        {
            Console.WriteLine($"Notification to {_name}: New offer available - {offer.getMessage()}");
        }

    }
}