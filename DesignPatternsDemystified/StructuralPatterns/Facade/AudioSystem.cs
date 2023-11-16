using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Facade
{
    public class AudioSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Audio System is turned on");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Setting volume to {volume}");
        }
    }
}
