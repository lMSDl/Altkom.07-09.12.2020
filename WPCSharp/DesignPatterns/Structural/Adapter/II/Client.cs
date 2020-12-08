using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public static class Client
    {
        public static void Execute()
        {
            var service = new DbPeopleService();
            var serviceAdapter = new DbPersonServiceAdapter(service);
            foreach(var person in serviceAdapter.Get())
            {
                ToString(person);
            }
        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
