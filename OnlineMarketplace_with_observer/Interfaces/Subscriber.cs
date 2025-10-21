using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace_with_observer.Interfaces
{
    public interface Subscriber
    {
        void Notify(string message);
    }
}
