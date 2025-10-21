
namespace DesignPatterns.Patterns.Structural.Facade.Subsystems
{
    internal class DvdPlayer
    {

        private string _movie;

        public void On() => Console.WriteLine("DVD Player: Power ON");
        public void Off() => Console.WriteLine("DVD Player: Power OFF");

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine($"DVD Player: Playing \"{movie}\"");
        }

        public void Stop()
        {
            Console.WriteLine($"DVD Player: Stopped playing \"{_movie}\"");
        }

        public void Eject() => Console.WriteLine("DVD Player: Ejecting disc");
    }
}
