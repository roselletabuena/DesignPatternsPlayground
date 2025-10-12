using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.AbstractFactory;
using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Abstract Factory + Singleton Example ===\n");

            var provider1 = ThemeFactoryProvider.Instance;
            var provider2 = ThemeFactoryProvider.Instance;

            Console.WriteLine($"Factory Provider Singleton? {provider1 == provider2}\n");

            // Simulate setting theme once in app startup
            var factory = provider1.GetFactory("dark");

            IButton button = factory.CreateButton();
            ICheckbox checkbox = factory.CreateCheckbox();

            button.Render();
            checkbox.Render();

            Console.WriteLine("\nSwitching theme mid-runtime (should reuse same factory instance):");
            var factoryAgain = provider2.GetFactory("light"); // Won’t change, still same factory

            factoryAgain.CreateButton().Render();
        }
    }
}
