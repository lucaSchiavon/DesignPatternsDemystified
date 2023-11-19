using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Flyweight
{
    //ConcreteFlyweight
    class Character : ICharacter
    {
        private char _symbol;

        public Character(char symbol)
        {
            _symbol = symbol;
        }

        public void Display(int position)
        {
            Console.WriteLine($"Character {_symbol} at position {position}");
        }
    }
}
