using DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Loggers;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Factory
{
    internal sealed class LoggerFactory : ILoggerFactory
    {
        private static readonly Lazy<LoggerFactory> _instance = new Lazy<LoggerFactory> (() => new LoggerFactory());
        
        public static LoggerFactory Instance => _instance.Value;

        private LoggerFactory() { }

        public ILogger CreateLogger(string type)
        {
            return type.ToLower() switch
            {
                "console" => new ConsoleLogger(),
                "file" => new FileLogger(),
                _ => throw new ArgumentException($"Logger type '{type}' is not supported")
            };
        }

    }
}
