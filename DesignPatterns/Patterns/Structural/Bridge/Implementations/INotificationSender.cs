

namespace DesignPatterns.Patterns.Structural.Bridge.Implementations
{
    internal interface INotificationSender
    {
        void Send(string subject, string message); 
    }
}
