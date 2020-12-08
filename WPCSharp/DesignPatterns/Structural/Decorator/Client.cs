using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Decorator
{
    public static class Client
    {
        public static void Execute()
        {
            var test = Console.ReadLine();

            var notification = (INotification)new Notification();
            Console.WriteLine("SMS?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new SmsNotification(notification);
            Console.WriteLine("Email?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new EmailNotification(notification);

            notification.Send(test);
        }
    }
}
