using System;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public class WorkingState : State
    {
        private int _workTime;
        private CancellationTokenSource _cancellationTokenSource;

        public WorkingState(int workTime)
        {
            this._workTime = workTime;
        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: przerywamy proces");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: przerywamy proces");
        }

        protected override void Init()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Delay(TimeSpan.FromSeconds(_workTime), _cancellationTokenSource.Token);
            task.ContinueWith(x =>
            {
                CoffeeMachine.TransitionTo(new IdleState());
                _cancellationTokenSource.Dispose();
            });
        }
    }
}