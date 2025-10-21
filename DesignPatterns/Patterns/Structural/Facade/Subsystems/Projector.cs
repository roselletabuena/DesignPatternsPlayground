

namespace DesignPatterns.Patterns.Structural.Facade.Subsystems
{
    internal class Projector
    {
        public void On() => Console.WriteLine("Projector: Power ON");
        public void Off() => Console.WriteLine("Projector: Power OFF");
        public void SetInput(string source) => Console.WriteLine($"Projector: Input set to {source}");
        public void WideScreenMode() => Console.WriteLine("Projector: Set to widescreen mode (16x9)");

    }
}
