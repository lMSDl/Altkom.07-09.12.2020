using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Behavioral.Iterator;
using WPCSharp.DesignPatterns.Behavioral.Memento;
using WPCSharp.DesignPatterns.Behavioral.NullObject;

namespace WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calc = new Calc();

            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calc.Strategy = GetCalcStrategy(split[1]);

                if (float.TryParse(split[0], out float val1) &&
                    float.TryParse(split[2], out float val2))
                {
                    calc.Value1 = val1;
                    calc.Value2 = val2;
                    var result = calc.Execute();
                    Console.WriteLine(result);
                    Console.WriteLine(GetFunc(split[1]).Invoke(val1, val2));
                }

            }
        }

        private static ICalcStrategy GetCalcStrategy(string arg)
        {
            switch (arg)
            {
                case "*":
                    return new MultiplyCalcStrategy();
                case "/":
                    return new DivideCalcStrategy();
                case "+":
                    return new PlusCalcStrategy();
                case "-":
                    return new MinusCalcStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float?> GetFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}
