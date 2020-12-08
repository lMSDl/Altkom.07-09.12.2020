using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public static class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            shape.Color = new RedColor();
            shape.Color.Brightness = new DarkBrightness();

            Console.WriteLine(shape);
        }
    }
}
