using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Flyweight
{
    //FlyweightFactory
    class CharacterFactory
    {
        private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char symbol)
        {
            if (!_characters.ContainsKey(symbol))
            {
                _characters[symbol] = new Character(symbol);
            }
            return _characters[symbol];
        }
    }
}
