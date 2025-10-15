

namespace DesignPatterns.Patterns.Structural.Bridge.Implementations
{
    internal class PushSender : INotificationSender
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"[Push] test {subject} -> {message} \n");
        }
    }
}
