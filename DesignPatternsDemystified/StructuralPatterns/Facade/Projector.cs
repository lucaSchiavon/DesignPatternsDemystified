using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Facade
{
    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector is turned on");
        }

        public void Project()
        {
            Console.WriteLine("Projecting on the screen");
        }
    }
}
