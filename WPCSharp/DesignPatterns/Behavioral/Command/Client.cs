using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "drzewo");
            var command2 = new PlantCommand(garden, "stokrotka");
            var command3 = new RemoveCommand(garden, "drzewo");
            var command4 = new RemoveCommand(garden, "stokrotka");

            var plantButton1 = new CommandsInvoker(command1);
            var plantButton2 = new CommandsInvoker(command2);
            var removeButton1 = new CommandsInvoker(command3);
            var removeButton2 = new CommandsInvoker(command4);
            var undoButton = new UndoCommandsInvoker();

            Console.WriteLine(garden);
            plantButton1.Invoke();
            plantButton2.Invoke();
            plantButton2.Invoke();
            plantButton1.Invoke();
            plantButton1.Invoke();
            plantButton1.Invoke();
            plantButton1.Invoke();
            plantButton1.Invoke();
            Console.WriteLine(garden);

            removeButton1.Invoke();
            removeButton1.Invoke();
            removeButton2.Invoke();
            Console.WriteLine(garden);

            undoButton.Invoke();
            undoButton.Invoke();
            undoButton.Invoke();
            undoButton.Invoke();
            undoButton.Invoke();
            undoButton.Invoke();
            Console.WriteLine(garden);

        }
    }
}
