using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Decorator
{
    // Concrete component
    public class SimpleCoffee : ICoffee
    {
        public int Cost()
        {
            return 5;
        }
    }
}
