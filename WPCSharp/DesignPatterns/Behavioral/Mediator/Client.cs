using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Behavioral.Iterator;
using WPCSharp.DesignPatterns.Behavioral.NullObject;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            ChatMember user1 = new ChatUser("User1");
            ChatMember bot1 = new ChatBot("Bot1");
            ChatMember bot2 = new ChatBot("Bot2");
            ChatMember bot3 = new ChatBot("Bot3");

            user1.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;
            bot3.Chat = chat;

            string @string;
            do
            {
                @string = Console.ReadLine();
                var split = @string.Split(':');
                if (split.Length == 2)
                    user1.Send(split[0], split[1]);
                else
                    user1.Send(@string);

            } while (@string != "quit");
        }
    }
}
