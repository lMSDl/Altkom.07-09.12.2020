using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.NullObject
{
    public class Client
    {
        public static Output Output { get; set; } = new NullOutput();

        public static void Execute()
        {
            while(true)
            {
                switch(Console.ReadKey().KeyChar)
                {
                    case 'c':
                        Output = new ConsoleOutput();
                        break;
                    case 'd':
                        Output = new DebugOutput();
                        break;
                    default:
                        Output = new NullOutput();
                        break;
                }
                Output.Show(Console.ReadLine());
            }
        }
    }
}
