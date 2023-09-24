using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.TemplateMethod
{
    // Concrete subclass 2 for creating a Veggie sandwich
    class VeggieSandwich : Sandwich
    {
        protected override void PrepareBread()
        {
            Console.WriteLine("Prepare whole wheat bread for Veggie sandwich.");
        }

        protected override void AddIngredients()
        {
            Console.WriteLine("Add lettuce, tomato, cucumber, and bell peppers.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add hummus and balsamic dressing.");
        }

        protected override void WrapSandwich()
        {
            Console.WriteLine("Wrap the Veggie sandwich in foil.");
        }
    }
}
