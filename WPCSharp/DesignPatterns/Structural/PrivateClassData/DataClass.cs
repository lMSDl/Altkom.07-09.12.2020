using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.PrivateClassData
{
    public class DataClass
    {
        private int _attr1;
        private int _attr2;

        public DataClass(int attr1, int attr2)
        {
            _attr1 = attr1;
            _attr2 = attr2;
        }

        public int GetAttr1()
        {
            return _attr1;
        }
        public int GetAttr2()
        {
            return _attr1;
        }
    }
}
