using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public static class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                Address = new List<string>() { "00-001 Warszwa", "ul. Krakowska 16" },
            };

            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Ewowska";
            p2.Address.Clear();

            Display(p1);

            Display(p2);
        }

        public static void Display(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
