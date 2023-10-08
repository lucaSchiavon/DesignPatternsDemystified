using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.FactoryMethod
{
    class ScienceFictionBookFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new ScienceFictionBook();
        }
    }
}
