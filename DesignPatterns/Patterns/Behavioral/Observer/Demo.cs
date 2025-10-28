

using DesignPatterns.Patterns.Behavioral.Observer.Model;

namespace DesignPatterns.Patterns.Behavioral.Observer
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Observer Pattern Demo ===\n");

            var agency = new NewsAgency();

            var mobileApp = new Subscriber("Mobile App");
            var website = new Subscriber("Website");
            var emailService = new Subscriber("Email Service");


            agency.Attach(mobileApp);
            agency.Attach(website);
            agency.Attach(emailService);


            // Publish News Updates
            agency.Notify("Global markets rally as inflation drops!");
            agency.Notify("Local elections scheduled for next month.");

            // Detach one observer
            agency.Detach(website);

            // Another news update
            agency.Notify("New electric car model breaks sales records!");

        }
    }
}
