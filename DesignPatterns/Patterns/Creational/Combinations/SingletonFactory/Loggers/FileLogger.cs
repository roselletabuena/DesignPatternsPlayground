
namespace DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Loggers
{
    internal class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath = "app.log")
        {
            _filePath = filePath; 
        }

        public void Log(string message)
        {
            var log = $"[File] {DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}";
            File.AppendAllText(_filePath, log);

        }


    }
}
