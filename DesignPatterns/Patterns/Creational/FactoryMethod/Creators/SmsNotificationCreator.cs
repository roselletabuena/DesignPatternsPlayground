using DesignPatterns.Patterns.Creational.FactoryMethod.Products;


namespace DesignPatterns.Patterns.Creational.FactoryMethod.Creators
{
    internal class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
