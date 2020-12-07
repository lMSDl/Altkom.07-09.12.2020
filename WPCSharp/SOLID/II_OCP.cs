using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.SOLID.O
{
    abstract class Shape
    {
        public abstract float Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override float Area
        {
            get
            {
                {
                    return A * A;
                }
            }
        }
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
            public override float Area
            {
                get
                {
                    {
                        return A * B;
                    }
                }
            }
    }


    class ShapeCalculator
    {
        float Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
