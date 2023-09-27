using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.TrafficLight
{
    // Concrete State classes
    public class RedState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Traffic light is red. Stop!");
            Thread.Sleep(2000); // Simulate red light duration
            trafficLight.ChangeState(new GreenState());
        }
    }
}
