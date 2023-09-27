using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer
{
    public class PausedState : IState
    {
        public void Play()
        {
            Console.WriteLine("Resuming the playback.");
        }

        public void Pause()
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the playback.");
        }
    }
}
