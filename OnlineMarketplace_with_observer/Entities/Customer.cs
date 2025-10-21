using OnlineMarketplace_with_observer.Interfaces;

namespace OnlineMarketplace_with_observer.Entities
{
    public class Customer : Subscriber
    {
        private string _name;
      
        public Customer(string name)
        {
            _name = name;
        }


        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

   

        public void Notify(string message)
        {
            Console.WriteLine("Notiyfing user: " + _name + ", about: " + message);
    
        }
    }
}