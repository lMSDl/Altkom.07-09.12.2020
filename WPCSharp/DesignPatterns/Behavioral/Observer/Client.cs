using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Behavioral.Iterator;
using WPCSharp.DesignPatterns.Behavioral.Memento;
using WPCSharp.DesignPatterns.Behavioral.NullObject;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var subject = new Publisher())
            {
                var observerA = new SubscriberA(subject);
                var observerB = new SubscriberB(subject);

                subject.Work();
                subject.Work();
                subject.Work();
                subject.Work();

                Console.WriteLine("Ręczna zmiana stanu");
                subject.Index = 10;

            }
        }
    }
}
