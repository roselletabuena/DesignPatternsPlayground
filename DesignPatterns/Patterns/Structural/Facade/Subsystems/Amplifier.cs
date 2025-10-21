
using System.Threading.Channels;

namespace DesignPatterns.Patterns.Structural.Facade.Subsystems
{
    internal class Amplifier
    {

        public void On() => Console.WriteLine("Amplifier: Power ON");
        public void Off() => Console.WriteLine("Amplifier: Power OFF");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier: Volume set to {level}");
        public void SetSource(string source) => Console.WriteLine($"Amplifier: Source set to {source}");
    }
}
