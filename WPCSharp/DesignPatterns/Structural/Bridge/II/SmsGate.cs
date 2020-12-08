using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class SmsGate : IMessageSenderImplementation
    {
        public const int MaxLength = 10;

        public void SendMessage(string message)
        {
            var splitterMessage = Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLength))
                .Select(x => message.Substring(x * MaxLength, Math.Min(MaxLength, message.Length - x * MaxLength)));

            foreach (var item in splitterMessage)
            {
                Console.WriteLine($"Wiadomość wsyłana przez SMS: {item}");
            }
        }
    }
}
