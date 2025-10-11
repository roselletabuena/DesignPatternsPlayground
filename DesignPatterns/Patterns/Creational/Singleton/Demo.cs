using System;

namespace DesignPatterns.Patterns.Creational.Singleton
{
    public class Demo
    {
        public static void Run()
        {
            Console.WriteLine("==== Singleton Pattern Demo ===");

            var settings1 = AppSettings.GetInstance();
            var settings2 = AppSettings.GetInstance();

            settings1.Theme = "Light";
            settings2.Display();

            Console.WriteLine($"Same instance? {ReferenceEquals(settings1, settings2)}");
        }
    }
}
