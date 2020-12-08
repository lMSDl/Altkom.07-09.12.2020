using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;
using WPCSharp.DesignPatterns.Structural.Decorator;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public static class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            database = new DatabaseProxy(database);

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}
