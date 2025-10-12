

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Loggers
{
    internal class ConsoleLogger : ILogger
    {

        public void Log(string message) 
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Console] {DateTime.Now:HH:mm:ss} - {message}");
            Console.ResetColor();
        }
    }
}
