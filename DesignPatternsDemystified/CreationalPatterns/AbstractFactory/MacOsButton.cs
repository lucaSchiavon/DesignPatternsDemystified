using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.AbstractFactory
{
    // Concrete Products for macOS
    class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a macOS button");
        }
    }
}
