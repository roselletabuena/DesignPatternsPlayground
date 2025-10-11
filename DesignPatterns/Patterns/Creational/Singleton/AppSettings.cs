using System;

namespace DesignPatterns.Patterns.Creational.Singleton
{
    internal sealed class AppSettings
    {
        private static AppSettings _instance;
        private static readonly object _lock = new object();

        private AppSettings()
        {
            ApplicationName = "Design Patterns Demo App";
            Version = "1.0.0";
            Theme = "Dark";
        }

        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppSettings();
                    }
                }
            }

            return _instance;
        }

        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public string Theme { get; set; }

        public void Display()
        {
            Console.WriteLine($"App: {ApplicationName}");
            Console.WriteLine($"Version: {Version}");
            Console.WriteLine($"Theme: {Theme}");


        }
    }
}
