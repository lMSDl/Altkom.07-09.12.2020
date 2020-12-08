using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public static class Client
    {
        public static void Execute()
        {
            MessageAbstraction message = new ShortMessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());

        }
    }
}
