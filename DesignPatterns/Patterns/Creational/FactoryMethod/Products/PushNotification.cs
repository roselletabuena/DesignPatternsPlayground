
namespace DesignPatterns.Patterns.Creational.FactoryMethod.Products
{
    internal class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"🔔 Push Notification: {message}");
        }
    }
}
