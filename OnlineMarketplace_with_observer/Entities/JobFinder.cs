using OnlineMarketplace_with_observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace_with_observer.Entities
{
    public class JobFinder : Subscriber
    {

        private string _name;

        public JobFinder(string name)
        {
            _name = name;
        }

         
        public string GetName()
        {
            return _name;
        }


        public void Notify(string message)
        {
            Console.WriteLine("Received job finder: " + _name + ", about: " + message);
        }

    }
}
