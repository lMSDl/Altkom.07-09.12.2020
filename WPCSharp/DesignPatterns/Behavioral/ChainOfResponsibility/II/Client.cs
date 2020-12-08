using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var button = new Button();
            button.Func = parent =>
            {
                if (string.IsNullOrWhiteSpace(((TextBox)parent).InputText))
                {
                    return false;
                }

                ((TextBox)parent).InputText = null;
                Console.WriteLine("TextBox clear");
                return true;
            };

            var textBox = new TextBox();
            textBox.Add(button);

            var frame = new Frame();
            frame.Add(textBox);

            button.Click();
            textBox.Click();
            frame.Click();

            textBox.InputText = "Some text";
            button.Click();
            button.Click();
            textBox.Click();
            frame.Click();


            Console.WriteLine(button.ClickCounter);
            Console.WriteLine(textBox.ClickCounter);
            Console.WriteLine(frame.ClickCounter);
        }
    }
}
