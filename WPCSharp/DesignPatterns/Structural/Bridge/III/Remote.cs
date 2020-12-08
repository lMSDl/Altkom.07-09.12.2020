using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public class Remote : IRemote
    {
        public IRemote DeviceAdapter { get; set; }

        public void ChannelDown()
        {
            DeviceAdapter.ChannelDown();
        }

        public void ChannelUp()
        {
            DeviceAdapter.ChannelUp();
        }

        public void TogglePower()
        {
            DeviceAdapter.TogglePower();
        }

        public void VolumeDown()
        {
            DeviceAdapter.VolumeDown();
        }

        public void VolumeUp()
        {
            DeviceAdapter.VolumeUp();
        }
    }
}
