

namespace DesignPatterns.Patterns.Structural.Bridge.Implementations
{
    internal class SmsSender : INotificationSender
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"[SMS] {subject}: {message} \n");
        }
    }
}
