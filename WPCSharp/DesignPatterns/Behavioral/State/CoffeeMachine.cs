using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class CoffeeMachine : IState
    {
        private State _state;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }

        public void SmallCoffee()
        {
            _state.LargeCoffee();
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"CoffeeMachine: Zmiana stanu na {state.GetType().Name}");
            _state = state;
            state.CoffeeMachine = this;
        }
    }
}
