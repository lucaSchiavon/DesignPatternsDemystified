using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.FactoryMethod
{
    //Create concrete Book classes.
    class MysteryBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading a mystery book.");
        }
    }
}
