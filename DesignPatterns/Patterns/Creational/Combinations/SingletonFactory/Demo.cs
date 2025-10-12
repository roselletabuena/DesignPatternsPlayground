
using DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Factory;
using DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Loggers;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonFactory
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("== Singleton + Factory Example ==\n");

            var factory1 = LoggerFactory.Instance;
            var factory2 = LoggerFactory.Instance;

            Console.WriteLine($"Factory1 == Factory2: {factory1 == factory2}");

            ILogger consoleLogger = factory1.CreateLogger("console");
            ILogger fileLogger = factory1.CreateLogger("file");

            consoleLogger.Log("Console logger initialized.");
            fileLogger.Log("File logger initialized.");

            consoleLogger.Log("Application started successfully");
            fileLogger.Log("Application log recorded a file.");
        }
    }
}
