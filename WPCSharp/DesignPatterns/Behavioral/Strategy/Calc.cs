using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Calc
    {
        public ICalcStrategy Strategy { private get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }

        public float Execute()
        {
            return Strategy.Calc(Value1, Value2);
        }
    }
}
