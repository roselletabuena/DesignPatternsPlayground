
namespace DesignPatterns.Patterns.Creational.FactoryMethod.Products
{
    internal class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📧 Email Notification: {message}");
        }
    }
}
