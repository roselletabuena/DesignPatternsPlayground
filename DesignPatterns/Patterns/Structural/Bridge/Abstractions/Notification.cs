using DesignPatterns.Patterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Patterns.Structural.Bridge.Abstractions
{
    internal abstract class Notification
    {
        protected readonly INotificationSender _sender;

        protected Notification(INotificationSender sender)
        {
            _sender = sender;
        }

        public abstract void Notify(string title, string message);
    }
}
