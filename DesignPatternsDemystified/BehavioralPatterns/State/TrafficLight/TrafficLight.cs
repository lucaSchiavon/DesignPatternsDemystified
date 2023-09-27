using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.TrafficLight
{
    // Context class
    public class TrafficLight
    {
        private ITrafficLightState currentState;

        public TrafficLight()
        {
            currentState = new RedState(); // Initial state is Red
        }

        public void ChangeState(ITrafficLightState newState)
        {
            currentState = newState;
        }

        public void Request()
        {
            currentState.Handle(this);
        }
    }
}
