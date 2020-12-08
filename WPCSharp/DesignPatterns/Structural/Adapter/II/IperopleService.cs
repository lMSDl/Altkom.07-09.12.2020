using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public interface IPeopleService
    {
        IEnumerable<IPerson> Get();
    }
}
