using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer
{
    // Concrete State classes
    public class PlayingState : IState
    {
        public void Play()
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing the playback.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the playback.");
        }
    }
}
