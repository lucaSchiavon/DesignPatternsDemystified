using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer
{
    public interface IState
    {
        void Play();
        void Pause();
        void Stop();
    }
}
