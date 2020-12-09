using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Publisher : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscibe(() => _observers.Remove(observer));
        }

        public int Index
        {
            get => index;
            set
            {
                index = value;
                Notify();
            }
        }

        public void Work()
        {
            Console.WriteLine($"{GetType().Name}: Wykonuję jakieś obliczenia");
            Thread.Sleep(1000);
            Index = new Random().Next(-1, 10);
            Console.WriteLine($"{GetType().Name}: Zmienił się mój stan na {Index}");
        }

        private void Notify()
        {
                if (Index >= 0)
                    _observers.ToList().ForEach(x => Task.Run(() => x.OnNext(Index)));
                else
                    _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException(Index.ToString())));
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
        }
    }
}
