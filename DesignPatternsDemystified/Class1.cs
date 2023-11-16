using System;

// Subsystem Classes
class DVDPlayer
{
    public void TurnOn()
    {
        Console.WriteLine("DVD Player is turned on");
    }

    public void PlayMovie(string movie)
    {
        Console.WriteLine($"Playing movie: {movie}");
    }
}

class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Audio System is turned on");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Setting volume to {volume}");
    }
}

class Projector
{
    public void TurnOn()
    {
        Console.WriteLine("Projector is turned on");
    }

    public void Project()
    {
        Console.WriteLine("Projecting on the screen");
    }
}

// Facade
class HomeTheaterFacade
{
    private DVDPlayer dvdPlayer;
    private AudioSystem audioSystem;
    private Projector projector;

    public HomeTheaterFacade()
    {
        dvdPlayer = new DVDPlayer();
        audioSystem = new AudioSystem();
        projector = new Projector();
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        dvdPlayer.TurnOn();
        audioSystem.TurnOn();
        projector.TurnOn();

        dvdPlayer.PlayMovie(movie);
        audioSystem.SetVolume(10);
        projector.Project();
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        dvdPlayer.TurnOn(); // Assuming there's a method to turn off each component
        audioSystem.TurnOn();
        projector.TurnOn();
    }
}

// Client
class Program
{
    static void Main()
    {
        // Using the Facade to simplify interaction with the subsystem
        HomeTheaterFacade homeTheater = new HomeTheaterFacade();
        homeTheater.WatchMovie("Inception");

        // After watching the movie, you can use the facade to clean up
        homeTheater.EndMovie();
    }
}