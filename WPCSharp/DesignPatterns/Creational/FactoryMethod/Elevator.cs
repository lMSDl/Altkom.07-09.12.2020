using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        public readonly Dictionary<string, IElevatorOperation> _operations;

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        }

        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }

        public void Execute(string action, int floor)
        {
            Execute(CreateOperation(action) , floor);
        }

        private IElevatorOperation CreateOperation(string action)
        {
            if (_operations.ContainsKey(action))
                return _operations[action];
            return null;


            IElevatorOperation operation = (IElevatorOperation)Activator.CreateInstance(Type.GetType($"{GetType().Namespace}.{nameof(Elevator)}{action}"));

            /*switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    operation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    operation = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    operation = new ElevatorGoTo();
                    break;
                default:
                    return null;
            }*/
            _operations[action] = operation;
            return operation;
        }
    }
}
