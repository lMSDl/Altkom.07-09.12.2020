using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
        public class EmailGate : IMessageSenderImplementation
        {
            public void SendMessage(string message)
            {
                Console.WriteLine($"Wiadomość wsyłana przez Email: {message}");
            }
    }
}
