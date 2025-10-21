

using DesignPatterns.Patterns.Structural.Decorator.Components;
using DesignPatterns.Patterns.Structural.Decorator.Decorators;
using DesignPatterns.Patterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Patterns.Structural.Decorator
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Decorator Pattern Demo ===\n");

            ICoffee espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()} - ${espresso.GetCost():0.00}");


            ICoffee milkEspresso = new MilkDecorator(espresso);
            Console.WriteLine($"{milkEspresso.GetDescription()} - ${milkEspresso.GetCost():0.00}");

            ICoffee deluxeLatte = new WhippedCreamDecorator(
                                        new SugarDecorator(
                                            new MilkDecorator(
                                                new Latte())));


            Console.WriteLine($"{deluxeLatte.GetDescription()} - ${deluxeLatte.GetCost():0.00}");

            // Add sugar twice (demonstrating stacking)
            ICoffee doubleSugar = new SugarDecorator(new SugarDecorator(new Espresso()));
            Console.WriteLine($"{doubleSugar.GetDescription()} - ${doubleSugar.GetCost():0.00}");

            Console.WriteLine("\nAll beverages prepared successfully!");
        }
    }
}
