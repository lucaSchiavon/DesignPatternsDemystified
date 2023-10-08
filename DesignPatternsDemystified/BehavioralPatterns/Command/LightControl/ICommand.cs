using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Command.LightControl
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
