using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public class Tv
    {
        public void ChannelDown()
        {
            Console.WriteLine("Tv channel down");
        }

        public void ChannelUp()
        {
            Console.WriteLine("Tv channel up");
        }

        public void TogglePower()
        {
            Console.WriteLine("Tv toggle power");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Tv volume up");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Tv volume down");
        }
    }
}
