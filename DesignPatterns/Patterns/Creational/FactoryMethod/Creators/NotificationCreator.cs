using DesignPatterns.Patterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Patterns.Creational.FactoryMethod.Creators
{
    internal abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        // Business logic that uses the product
        public void Notify(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }
}
