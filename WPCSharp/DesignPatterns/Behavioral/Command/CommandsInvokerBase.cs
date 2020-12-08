using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public abstract class CommandsInvokerBase
    {
        protected static readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public abstract void Invoke();
    }
}
