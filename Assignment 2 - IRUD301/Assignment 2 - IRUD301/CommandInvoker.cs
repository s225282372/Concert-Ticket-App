using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public class CommandInvoker
    {
        private List<ICommand> command_history;

        public CommandInvoker()
        {
            command_history = new List<ICommand>();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            command_history.Add(command);
        }

        public void UndoLastCommand()
        {
            if (command_history.Count > 0)
            {
                ICommand lastCommand = command_history[command_history.Count - 1];
                lastCommand.Undo();
                command_history.RemoveAt(command_history.Count - 1);
            }
            else
            {
                Console.WriteLine("No commands to undo!");
            }
        }

        public void ShowCommandHistory()
        {
            Console.WriteLine($"\nCommand History: {command_history.Count} commands executed");
        }

    }
}
