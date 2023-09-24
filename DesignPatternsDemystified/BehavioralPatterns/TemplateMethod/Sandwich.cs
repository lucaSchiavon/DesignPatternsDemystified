using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.TemplateMethod
{
    // Abstract class defining the template method
    abstract class Sandwich
    {
        public void MakeSandwich()
        {
            PrepareBread();
            AddIngredients();
            AddCondiments();
            WrapSandwich();
        }

        protected abstract void PrepareBread();
        protected abstract void AddIngredients();
        protected abstract void AddCondiments();
        protected virtual void WrapSandwich()
        {
            Console.WriteLine("Wrap the sandwich in paper.");
        }
    }
}
