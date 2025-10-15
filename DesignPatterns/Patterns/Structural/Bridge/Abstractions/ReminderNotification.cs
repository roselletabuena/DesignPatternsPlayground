

namespace DesignPatterns.Patterns.Structural.Bridge.Abstractions
{
    internal class ReminderNotification : Notification
    {
        public ReminderNotification(Implementations.INotificationSender sender) : base(sender) { }

        public override void Notify(string title, string message)
        {
            _sender.Send($"Reminder: {title}", message);
        }
    }
}
