using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Command.LightControl
{
    // Invoker
    public class RemoteControl
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void PressButton(int index)
        {
            if (index >= 0 && index < _commands.Count)
            {
                _commands[index].Execute();
            }
        }

        public void UndoButton(int index)
        {
            if (index >= 0 && index < _commands.Count)
            {
                _commands[index].Undo();
            }
        }
    }
}
