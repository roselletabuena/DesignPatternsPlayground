
using DesignPatterns.Patterns.Creational.FactoryMethod.Creators;

namespace DesignPatterns.Patterns.Creational.FactoryMethod
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("== Factory Method Demo == \n");

            var emailCreator = new EmailNotificationCreator();
            emailCreator.Notify("Welcome to our app");

            var smsCreator = new SmsNotificationCreator();
            smsCreator.Notify("Your OTP is 123456");

            var pushCreator = new PushNotificationCreator();
            pushCreator.Notify("You have a new follower!");
        }
    }
}
