using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Flyweight
{
    //Client
    class TextEditor
    {
        private List<Tuple<int, char>> _characters = new List<Tuple<int, char>>();
        private CharacterFactory _characterFactory = new CharacterFactory();

        public void InsertCharacter(char symbol, int position)
        {
            ICharacter character = _characterFactory.GetCharacter(symbol);
            _characters.Add(new Tuple<int, char>(position, symbol));
            character.Display(position);
        }

        public void DisplayText()
        {
            foreach (var tuple in _characters)
            {
                Console.WriteLine($"Character {tuple.Item2} at position {tuple.Item1}");
            }
        }
    }

}
