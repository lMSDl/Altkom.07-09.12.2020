using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    class TvAdapter : IRemote
    {
        private Tv _tv;

        public TvAdapter(Tv tv)
        {
            _tv = tv;
        }

        public void ChannelDown()
        {
            _tv.ChannelDown();
        }

        public void ChannelUp()
        {
            _tv.ChannelUp();
        }

        public void TogglePower()
        {
            _tv.TogglePower();
        }

        public void VolumeDown()
        {
            _tv.VolumeDown();
        }

        public void VolumeUp()
        {
            _tv.VolumeUp();
        }
    }
}
