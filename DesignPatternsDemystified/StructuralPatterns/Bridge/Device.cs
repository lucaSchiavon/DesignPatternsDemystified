using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Bridge
{
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }

}
