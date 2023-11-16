using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Facade
{
    public class DVDPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("DVD Player is turned on");
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Playing movie: {movie}");
        }
    }
}
