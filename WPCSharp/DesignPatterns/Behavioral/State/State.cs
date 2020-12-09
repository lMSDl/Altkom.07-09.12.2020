using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public abstract class State : IState
    {
        private CoffeeMachine coffeeMachine;

        public CoffeeMachine CoffeeMachine
        {
            protected get => coffeeMachine;
            set
            {
                coffeeMachine = value;
                Init();
            }
        }

        protected abstract void Init();
        public abstract void LargeCoffee();
        public abstract void SmallCoffee();
    }
}
