using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.FactoryMethod
{
    //Implement concrete factory classes.
    class MysteryBookFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new MysteryBook();
        }
    }
}
