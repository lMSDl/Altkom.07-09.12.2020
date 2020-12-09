using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class DivideCalcStrategy : ICalcStrategy
    {
        public float Calc(float val1, float val2)
        {
            return val1 / val2;
        }
    }
}
