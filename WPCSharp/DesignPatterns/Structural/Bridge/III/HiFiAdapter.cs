using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    class HiFiAdapter : IRemote
    {
        private HiFi _hiFi;

        public HiFiAdapter(HiFi hifi)
        {
            _hiFi = hifi;
        }

        public void ChannelDown()
        {
        }

        public void ChannelUp()
        {
        }

        private bool _powerState;
        public void TogglePower()
        {
            if (_powerState)
                _hiFi.PowerOff();
            else
                _hiFi.PowerOn();
            _powerState = !_powerState;
        }

        public void VolumeDown()
        {
            _hiFi.VolumeDown();
        }

        public void VolumeUp()
        {
            _hiFi.VolumeUp();
        }
    }
}
