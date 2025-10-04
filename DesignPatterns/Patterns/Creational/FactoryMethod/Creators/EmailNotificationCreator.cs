
using DesignPatterns.Patterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Patterns.Creational.FactoryMethod.Creators
{
    internal class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
