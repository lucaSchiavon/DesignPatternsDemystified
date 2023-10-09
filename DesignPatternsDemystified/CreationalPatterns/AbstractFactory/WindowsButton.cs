using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.AbstractFactory
{
    // Concrete Products for Windows OS
    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a Windows button");
        }
    }
}
