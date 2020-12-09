using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        private IChatMediator _chat;

        public string Nick { get; }
        public IChatMediator Chat
        {
            get => _chat;
            set
            {
                if (_chat != null)
                    _chat.Quit(this);
                _chat = value;
                if (_chat != null)
                    _chat.Join(this);
            }
        }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public void Send(string message)
        {
            Chat?.Notify(Nick, message);
        }
        public void Send(string to, string message)
        {
            Chat?.Notify(Nick, to, message);
        }

        public virtual void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
            {
                Console.WriteLine($"{from} to {Nick}: {message}");
            }
            else
            {
                Console.WriteLine($"{from}: {message}");
            }
        }
    }
}
