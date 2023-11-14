using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Composite
{
    public class TextBox : UIComponent
    {
        private string content;

        public TextBox(string content)
        {
            this.content = content;
        }

        public override void Display()
        {
            Console.WriteLine($"TextBox: {content}");
        }
    }
}
