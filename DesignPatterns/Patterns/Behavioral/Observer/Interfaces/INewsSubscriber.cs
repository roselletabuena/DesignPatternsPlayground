
namespace DesignPatterns.Patterns.Behavioral.Observer.Interfaces
{
    /// <summary>
    /// The Observer interface defines a method for receiving updates from the Subject.
    /// </summary>
    internal interface INewsSubscriber
    {

        void Update(string news);

    }
}
