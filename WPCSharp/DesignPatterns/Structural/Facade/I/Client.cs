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

namespace WPCSharp.DesignPatterns.Structural.Facade.I
{
    public static class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", Age = 32 };

            JsonConvertFacade.Serialize(item);
        }
    }
}
