using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Bridge
{
    class SonyTv : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: set channel $number" + number);

        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
    }

}
