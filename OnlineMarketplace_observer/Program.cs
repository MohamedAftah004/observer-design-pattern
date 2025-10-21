using System.ComponentModel;

namespace OnlineMarketplace {
    class Program
    {
        static void Main(string[] args)
        {

            OnlineMarketplace onlineMarketplace = new OnlineMarketplace();



            //users
            User mohamed = new User("Mohamed", true, true);
            User youssef = new User("Youssef", true, false);
            User mahmoud = new User("mahmoud", false, true);
            User ali = new User("Ali", false, false);


            //products
            Product laptop = new Product("Laptop", 999.99m);
            Product keyboard = new Product("Keyboard", 49.99m);
            Product monitor = new Product("Monitor", 199.99m);

            //offers
            Offer summerSale = new Offer("Summer Sale: Up to 50% off on selected items!");



            //ading users to marketplace 
            onlineMarketplace.addUser(mohamed);
            onlineMarketplace.addUser(youssef);

            //adding products to marketplace
            onlineMarketplace.addProduct(laptop);

            //addig offers
            onlineMarketplace.addOffer(summerSale);



        }
    }
}