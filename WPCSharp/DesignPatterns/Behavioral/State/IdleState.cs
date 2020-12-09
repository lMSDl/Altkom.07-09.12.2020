namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            System.Console.WriteLine("IdleState: Rozpoczynam przygotowanie dużej kawy");
            CoffeeMachine.TransitionTo(new WorkingState(8));
        }

        public override void SmallCoffee()
        {
            System.Console.WriteLine("IdleState: Rozpoczynam przygotowanie małej kawy");
            CoffeeMachine.TransitionTo(new WorkingState(5));
        }

        protected override void Init()
        {
        }
    }
}