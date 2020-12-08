using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}
