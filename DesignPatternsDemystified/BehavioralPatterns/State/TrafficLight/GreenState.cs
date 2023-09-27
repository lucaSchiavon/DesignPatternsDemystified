using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.TrafficLight
{
    public class GreenState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Traffic light is green. Go!");
            Thread.Sleep(2000); // Simulate green light duration
            trafficLight.ChangeState(new YellowState());
        }
    }
}
