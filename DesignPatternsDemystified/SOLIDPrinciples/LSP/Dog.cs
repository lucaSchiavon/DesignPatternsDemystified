using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.LSP
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("A dog barks.");
        }
    }
}
