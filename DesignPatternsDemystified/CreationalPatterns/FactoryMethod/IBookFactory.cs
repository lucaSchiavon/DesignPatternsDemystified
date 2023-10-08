using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.FactoryMethod
{
    //Define a factory interface or abstract class.
    interface IBookFactory
    {
        IBook CreateBook();
    }
}
