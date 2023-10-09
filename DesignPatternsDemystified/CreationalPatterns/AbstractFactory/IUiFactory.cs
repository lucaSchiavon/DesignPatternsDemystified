using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.AbstractFactory
{
    // Abstract Factory
    interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

}
