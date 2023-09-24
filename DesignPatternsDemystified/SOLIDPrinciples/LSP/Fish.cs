using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.LSP
{
    public class Fish : Animal
    {

        public override void MakeSound()
        {
            // This class does not override the MakeSound method becouse Fish doesn't make sound
            Console.WriteLine("A fish doesn't make sound");
        }
    }

}
