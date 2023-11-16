using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Facade
{
    class HomeTheaterFacade
    {
        private DVDPlayer dvdPlayer;
        private AudioSystem audioSystem;
        private Projector projector;

        public HomeTheaterFacade()
        {
            dvdPlayer = new DVDPlayer();
            audioSystem = new AudioSystem();
            projector = new Projector();
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            dvdPlayer.TurnOn();
            audioSystem.TurnOn();
            projector.TurnOn();

            dvdPlayer.PlayMovie(movie);
            audioSystem.SetVolume(10);
            projector.Project();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater...");
            dvdPlayer.TurnOn(); // Assuming there's a method to turn off each component
            audioSystem.TurnOn();
            projector.TurnOn();
        }
    }
}
