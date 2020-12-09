using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.State
{
    public interface IState
    {
        void LargeCoffee();
        void SmallCoffee();
    }
}
