using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public interface IRemote
    {
        void ChannelDown();

        void ChannelUp();

        void TogglePower();

        void VolumeDown();

        void VolumeUp();
    }
}
