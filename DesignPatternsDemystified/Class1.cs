using System;
using System.Threading;

// State interface
public interface ITrafficLightState
{
    void Handle(TrafficLight trafficLight);
}

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

public class YellowState : ITrafficLightState
{
    public void Handle(TrafficLight trafficLight)
    {
        Console.WriteLine("Traffic light is yellow. Prepare to stop.");
        Thread.Sleep(1000); // Simulate yellow light duration
        trafficLight.ChangeState(new RedState());
    }
}

public class GreenState : ITrafficLightState
{
    public void Handle(TrafficLight trafficLight)
    {
        Console.WriteLine("Traffic light is green. Go!");
        Thread.Sleep(2000); // Simulate green light duration
        trafficLight.ChangeState(new YellowState());
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();

        for (int i = 0; i < 5; i++)
        {
            trafficLight.Request();
        }
    }
}
