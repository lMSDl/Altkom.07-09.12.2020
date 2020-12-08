using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Creational.Builder;
using WPCSharp.DesignPatterns.Creational.FactoryMethod;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public static class Client
    {
        public static void Execute()
        {
            var remote = new Remote();
            var tvRemoteAdapter = new TvAdapter(new Tv());
            var hiFiRemoteAdapter = new HiFiAdapter(new HiFi());


            remote.DeviceAdapter = tvRemoteAdapter;
            remote.TogglePower();
            remote.ChannelDown();
            remote.VolumeUp();

            remote.DeviceAdapter = hiFiRemoteAdapter;
            remote.TogglePower();
            remote.ChannelDown();
            remote.VolumeUp();

            remote.DeviceAdapter = tvRemoteAdapter;
            remote.TogglePower();

            remote.DeviceAdapter = hiFiRemoteAdapter;
            remote.TogglePower();
        }
    }
}
