using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class BaseHandler 
    {
        protected IHandler NextHander { get; }

        public BaseHandler(IHandler nextHander)
        {
            NextHander = nextHander;
        }

        public string Name { get; set; }
    }
}
