using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public static class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order(new HondaFactory(), nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new HondaFactory(), nameof(ISuv), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());

        }
    }
}
