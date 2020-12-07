using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Address { get; set; }

        public object Clone()
        {
            var clone = (Person)ShallowClone();
            clone.Address = Address.ToList();

            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }
}
