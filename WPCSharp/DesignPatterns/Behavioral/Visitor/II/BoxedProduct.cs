using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public class BoxedProduct : Product
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }
    }
}
