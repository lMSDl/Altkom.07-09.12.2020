using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class DarkBrightness : Brightness
    {
        public override string Value => "Dark";
    }
}
