using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public abstract class Command<T> : ICommand
    {
        protected T _receiver;
        protected string _plant;

        protected Command(T receiver, string plant)
        {
            _receiver = receiver;
            _plant = plant;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}
