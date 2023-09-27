using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer
{
    // Context class
    public class AudioPlayer
    {
        private IState currentState;

        public AudioPlayer()
        {
            currentState = new StoppedState(); // Initial state is Stopped
        }

        public void ChangeState(IState newState)
        {
            currentState = newState;
        }

        public void Play()
        {
            currentState.Play();
        }

        public void Pause()
        {
            currentState.Pause();
        }

        public void Stop()
        {
            currentState.Stop();
        }
    }
}
