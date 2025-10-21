

namespace DesignPatterns.Patterns.Structural.Facade.Subsystems
{
    internal class TheaterLights
    {
        public void On() => Console.WriteLine("Lights: ON (Full Brightness)");
        public void Dim(int level) => Console.WriteLine($"Lights: Dimmed to {level}% brightness");
    }
}
