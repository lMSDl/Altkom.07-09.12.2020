using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public class HiFi
    {
        public void PowerOn()
        {
            Console.WriteLine("HiFi power on");
        }

        public void PowerOff()
        {
            Console.WriteLine("HiFi power off");
        }

        public void VolumeDown()
        {
            Console.WriteLine("HiFi volume up");
        }

        public void VolumeUp()
        {
            Console.WriteLine("HiFi volume down");
        }
    }
}
