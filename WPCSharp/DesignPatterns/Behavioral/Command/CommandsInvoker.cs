using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class CommandsInvoker : CommandsInvokerBase
    {
        private ICommand _command;

        public CommandsInvoker(ICommand command)
        {
            _command = command;
        }

        public override void Invoke()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }

    }
}
