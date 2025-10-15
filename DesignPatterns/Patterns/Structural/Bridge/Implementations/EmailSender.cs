
namespace DesignPatterns.Patterns.Structural.Bridge.Implementations
{
    internal class EmailSender : INotificationSender
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"[Email] Subject: {subject}\n{message}");
        }
    }
}
