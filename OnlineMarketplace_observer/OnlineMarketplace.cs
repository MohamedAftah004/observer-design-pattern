

namespace OnlineMarketplace
{
    public class OnlineMarketplace
    {

        private List<User> Users;
        private List<Product> Products;
        private List<Offer> Offers;

        public OnlineMarketplace()
        {
            Users = new List<User>();
            Products = new List<Product>();
            Offers = new List<Offer>();
        }

        public void addUser(User user)
        {
            Users.Add(user);
        }


        public void addProduct(Product product)
        {
            Products.Add(product);
            notifyUsers(product);
        }

     

        public void notifyUsers(Product product)
        {
            Console.WriteLine($"-----------------      [Notification for product: ({product.getName()})]      --------------------");

            Users.ForEach(user =>
            {
                if (!user.isSubscribedToProducts())
                {
                    return;
                }
                user.notify(product);
            });
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

        }

        public void addOffer(Offer offer)
        {
            Offers.Add(offer);
            notifyUsers(offer);
        }
        public void notifyUsers(Offer offer)
        {
            Console.WriteLine($"--------------------------      [Notification for offer]      ----------------------------------");
            Users.ForEach(user =>
            {
                if (!user.isSubscribedToProducts())
                {
                    return;
                }
                user.notify(offer);
            });
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

        }



    }
}
