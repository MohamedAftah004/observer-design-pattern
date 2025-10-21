using System.Security.Cryptography.X509Certificates;

namespace OnlineMarketplace
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

        public string getName()
        {
            return _name;
        }



        public decimal getPrice()
        {
            return _price;
        }

    }
}