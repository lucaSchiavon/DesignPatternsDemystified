using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Composite
{
    public class Button : UIComponent
    {
        private string label;

        public Button(string label)
        {
            this.label = label;
        }

        public override void Display()
        {
            Console.WriteLine($"Button: {label}");
        }
    }
}
