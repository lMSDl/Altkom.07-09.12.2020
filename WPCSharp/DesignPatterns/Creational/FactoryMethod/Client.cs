using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public static class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();
            var action = "GoTo";
            elevator.Execute(action, 3);
            elevator.Execute("Up", 6);
            elevator.Execute("Down", 1);
        }
    }
}
