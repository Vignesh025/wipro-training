using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewsAgency agency = new NewsAgency();


            IObserver sub1 = new Subscriber("Cristiano");
            IObserver sub2 = new Subscriber("Ronaldo");

            agency.AddSubscriber(sub1);
            agency.AddSubscriber(sub2);

            agency.NotifySubscribers("There is a change in temperature");
        }
    }
}