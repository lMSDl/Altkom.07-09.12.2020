using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.NullObject
{
    public class DebugOutput : Output
    {
        public override void Show(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
