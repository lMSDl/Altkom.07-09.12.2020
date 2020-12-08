using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<Component, bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && !Func.Invoke(Parent))
                base.Click(handled);
            else
                base.Click(true);
        }
    }
}
