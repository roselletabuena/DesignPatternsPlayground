

using DesignPatterns.Patterns.Structural.Facade.Facade;
using DesignPatterns.Patterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Patterns.Structural.Facade
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("=== Facade Pattern Demo ===\n");

            // Create subsystem components
            var amp = new Amplifier();
            var dvd = new DvdPlayer();
            var projector = new Projector();
            var lights = new TheaterLights();

            // Create Facade
            var homeTheater = new HomeTheaterFacade(amp, dvd, projector, lights);

            // Use simplified interface
            homeTheater.WatchMovie("Inception");
            homeTheater.EndMovie();
        }
    }
}
