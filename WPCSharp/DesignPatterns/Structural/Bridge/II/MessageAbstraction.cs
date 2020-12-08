using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class MessageAbstraction
    {
        private IMessageSenderImplementation MessageSender { get; }

        public MessageAbstraction(IMessageSenderImplementation messageSender)
        {
            MessageSender = messageSender;
        }

        public virtual void Send(string message)
        {
            message = PrepareMessage(message);
            MessageSender.SendMessage(message);
        }

        private string PrepareMessage(string message)
        {
            return message.ToUpper();
        }
    }
}
