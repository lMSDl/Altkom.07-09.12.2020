using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public abstract class Subscriber : IObserver<int>
    {
        private IDisposable _subscription;

        protected Subscriber(IObservable<int> publisher)
        {
            _subscription = publisher.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: Transmisja zakończona");
            _subscription.Dispose();
            _subscription = null;
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: Error: {error.Message}");
        }

        public abstract void OnNext(int value);
    }
}
