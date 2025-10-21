using System.Security.Cryptography.X509Certificates;

namespace OnlineMarketplace_with_observer.Entities
{
    public class Product
    {

        private string _name;
        private decimal _price;

        public Product(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }



        public decimal GetPrice()
        {
            return _price;
        }

    }
}