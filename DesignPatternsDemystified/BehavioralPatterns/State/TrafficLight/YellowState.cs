using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.State.TrafficLight
{
    public class YellowState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Traffic light is yellow. Prepare to stop.");
            Thread.Sleep(1000); // Simulate yellow light duration
            trafficLight.ChangeState(new RedState());
        }
    }
}
