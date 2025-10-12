using DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Loggers;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Factory
{
    internal interface ILoggerFactory
    {
        ILogger CreateLogger(string type);
    }
}
