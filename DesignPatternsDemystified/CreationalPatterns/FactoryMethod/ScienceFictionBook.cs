using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.FactoryMethod
{
    class ScienceFictionBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading a science fiction book.");
        }
    }
}
