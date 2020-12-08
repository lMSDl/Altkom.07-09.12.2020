using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Adapter.I
{
    public static class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { Radius = 5 };
            var square = new Square() { Width = 8 };

            Console.WriteLine(Check(circle));
            Console.WriteLine(Check(new SquareToCircleAdapter(square)));
        }

        public static bool Check(ICircle circle)
        {
            return circle.Radius <= 5;
        }
    }
}
