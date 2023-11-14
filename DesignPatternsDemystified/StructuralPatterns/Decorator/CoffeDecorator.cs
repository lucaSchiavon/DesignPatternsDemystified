using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Decorator
{
    // Decorator
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual int Cost()
        {
            return _coffee.Cost();
        }
    }

}
