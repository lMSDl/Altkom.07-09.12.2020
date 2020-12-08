using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class UndoCommandsInvoker : CommandsInvokerBase
    {
        public override void Invoke()
        {
            _commands.Pop()?.Undo();
        }
    }
}
