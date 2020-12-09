using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class SubscriberA : Subscriber
    {
        public SubscriberA(IObservable<int> publisher) : base(publisher)
        {
        }

        public override void OnNext(int value)
        {
            Thread.Sleep(10000);
            if(value > 5)
            {
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
            }
        }
    }
}
