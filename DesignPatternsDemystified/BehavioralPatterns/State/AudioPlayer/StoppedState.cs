using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer
{
    public class StoppedState : IState
    {
        public void Play()
        {
            Console.WriteLine("Starting playback.");
        }

        public void Pause()
        {
            Console.WriteLine("Cannot pause, the player is stopped.");
        }

        public void Stop()
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
