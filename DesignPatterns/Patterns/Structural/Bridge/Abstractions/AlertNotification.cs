

namespace DesignPatterns.Patterns.Structural.Bridge.Abstractions
{
    internal class AlertNotification : Notification
    {
        public AlertNotification(Implementations.INotificationSender sender) : base(sender) { }

        public override void Notify(string title, string message)
        {
             _sender.Send($"ALERT: {title}", $"[CRITICAL] {message}");
        }
    }
}
