using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.PrivateClassData
{
    public class SomeClass
    {
        /*public int Attr1 { get; }
        public int Attr2 { get; }*/
        private DataClass _dataClass;

        public SomeClass(int attr1, int attr2)
        {
            /*Attr1 = attr1;
            Attr1 = attr2;*/
            _dataClass = new DataClass(attr1, attr2);
        }

        public void Method()
        {
            Console.WriteLine($"{_dataClass.GetAttr1()} {_dataClass.GetAttr1()}");
        }
    }
}
