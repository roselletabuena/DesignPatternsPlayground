
using DesignPatterns.Patterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Patterns.Structural.Facade.Facade
{
    internal class HomeTheaterFacade
    {

        private readonly Amplifier _amp;
        private readonly DvdPlayer _dvd;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, TheaterLights lights)
        {
            _amp = amp;
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("\n=== Get Ready to Watch a Movie ===");
            _lights.Dim(30);
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetSource("DVD");
            _amp.SetVolume(7);
            _dvd.On();
            _dvd.Play(movie);
            Console.WriteLine("Movie is now playing. Enjoy!\n");
        }

        public void EndMovie()
        {
            Console.WriteLine("\n=== Shutting Movie Theater Down ===");
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
            _amp.Off();
            _projector.Off();
            _lights.On();
            Console.WriteLine("Movie session ended.\n");
        }
    }
}
