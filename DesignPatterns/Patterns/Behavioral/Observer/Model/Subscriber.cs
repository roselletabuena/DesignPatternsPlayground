using DesignPatterns.Patterns.Behavioral.Observer.Interfaces;


namespace DesignPatterns.Patterns.Behavioral.Observer.Model
{
    /// <summary>
    /// Concrete Observer — reacts to updates from the Subject.
    /// </summary>
    internal class Subscriber : INewsSubscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string news)
        {
           Console.WriteLine($"[{_name}] received update: \"{news}\"");
        }
    }
}
