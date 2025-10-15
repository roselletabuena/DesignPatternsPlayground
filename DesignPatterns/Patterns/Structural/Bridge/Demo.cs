using DesignPatterns.Patterns.Structural.Bridge.Abstractions;
using DesignPatterns.Patterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Patterns.Structural.Bridge
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("=== Bridge Pattern Demo ===");

            var emailSender = new EmailSender();
            var smsSender = new SmsSender();
            var pushSender = new PushSender();

            var systemAlert = new AlertNotification(emailSender);
            var userReminder = new ReminderNotification(pushSender);
            var smsAlert = new AlertNotification(smsSender);

            systemAlert.Notify("Database Down", "Production database is not responding!");
            userReminder.Notify("Meeting at 3 PM", "Don't forget your project review meeting.");
            smsAlert.Notify("Server Restart", "Scheduled maintenance will start in 10 minutes.");

            Console.WriteLine("All notifications sent successfully!");

        }
    }
}
