using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private T _originator;
        private Stack<IMemento<T>> _history = new Stack<IMemento<T>>();

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            Console.WriteLine("Zapisywanie stanu");
            _history.Push(new Memento<T>((T)_originator.Clone()));
        }

        public void Undo()
        {
            if (!_history.Any())
                return;
            Console.WriteLine("Przywracanie stanu");
            var memento = _history.Pop();
            _originator.Restore(memento.State);
        }

        public void Peek(DateTime dateTime)
        {
            if (!_history.Any())
                return;
            Console.WriteLine($"Przywracanie stanu z {dateTime}");

            var memento = _history.FirstOrDefault(x => x.DateTime <= dateTime);
            if(memento != null)
                _originator.Restore(memento.State);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Posiadam migawki:");
            _history.ToList().ForEach(x => builder.AppendLine(x.DateTime.ToString("U")));
            return builder.ToString();
        }
    }
}
