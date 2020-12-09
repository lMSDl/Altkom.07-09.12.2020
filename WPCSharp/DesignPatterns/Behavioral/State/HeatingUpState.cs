using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: Rozgrzewam się!");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: Rozgrzewam się!");
        }

        protected override void Init()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransitionTo(new IdleState()));
        }
    }
}
