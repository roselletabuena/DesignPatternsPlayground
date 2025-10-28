

namespace DesignPatterns.Patterns.Behavioral.Observer.Interfaces
{

    /// <summary>
    /// The Subject interface defines methods to attach, detach, and notify observers.
    /// </summary>
    internal interface INewsPublisher
    {
        void Attach(INewsSubscriber subscriber);
        void Detach(INewsSubscriber subscriber);
        void Notify(string news);
    }
}
