using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Color
    {
        public abstract string ColorValue { get; }

        public Brightness Brightness { get; set; }

        public override string ToString()
        {
            return Brightness == null ? ColorValue : Brightness.Value + ColorValue;
        }
    }
}
