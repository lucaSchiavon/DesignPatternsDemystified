using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.TemplateMethod
{
    // Concrete subclass 1 for creating a BLT sandwich
    class BLTSandwich : Sandwich
    {
        protected override void PrepareBread()
        {
            Console.WriteLine("Prepare white bread for BLT.");
        }

        protected override void AddIngredients()
        {
            Console.WriteLine("Add bacon, lettuce, and tomato.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add mayonnaise and mustard.");
        }
    }
}
