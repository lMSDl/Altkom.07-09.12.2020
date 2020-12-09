using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public interface IMemento<T>
    {
        T State { get; }
        DateTime DateTime { get; }
    }
}
