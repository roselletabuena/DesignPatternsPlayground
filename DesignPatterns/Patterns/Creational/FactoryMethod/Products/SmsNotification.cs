
namespace DesignPatterns.Patterns.Creational.FactoryMethod.Products
{
    internal class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📱 SMS Notification: {message}");
        }
    }
}
