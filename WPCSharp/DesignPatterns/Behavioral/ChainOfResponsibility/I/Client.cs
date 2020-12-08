using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class Client
    {
        public static void Execute()
        {
            var handler5 = new DiscountHandler(500, 4500) { Name = "5" };
            var handler4 = new DiscountHandler(500, 5000, handler5) { Name = "4" };
            var handler3 = new DiscountHandler(200, 8000, handler4) { Name = "3" };
            var handler2 = new DiscountHandler(100, 8000, handler3) { Name = "2" };
            var handler1 = new DiscountHandler(100, 10000, handler2) { Name = "1" };


            Console.WriteLine(handler1.Discount(250, 8000));
            Console.WriteLine(handler1.Discount(1000, 8000));
            Console.WriteLine(handler3.Discount(300, 10000));
        }
    }
}
