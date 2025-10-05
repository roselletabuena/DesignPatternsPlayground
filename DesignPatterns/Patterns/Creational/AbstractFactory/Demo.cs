using DesignPatterns.Patterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("Select platform: 1 = Windows, 2 = macOS");
            string? choice = Console.ReadLine();

            IUIFactory factory = choice switch
            {
                "1" => new WindowsUIFactory(),
                "2" => new MacUIFactory(),
                _ => throw new InvalidOperationException("Unknown Platform")
            };

            var app = new Application(factory);
            app.RenderUI();

        }
    }
}
