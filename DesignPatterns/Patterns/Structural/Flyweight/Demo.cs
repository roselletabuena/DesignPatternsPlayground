
using DesignPatterns.Patterns.Structural.Flyweight.Factories;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("=== Flyweight Pattern Demo ===\n");

            var forest = new Forest();

            forest.PlantTree(10, 20, "Oak", "Green", "Rough");
            forest.PlantTree(15, 25, "Oak", "Green", "Rough");
            forest.PlantTree(50, 80, "Pine", "Dark Green", "Smooth");
            forest.PlantTree(60, 90, "Pine", "Dark Green", "Smooth");
            forest.PlantTree(100, 200, "Cherry Blossom", "Pink", "Soft");


            forest.Draw();

            Console.WriteLine($"\nTotal unique tree types created: {TreeFactory.GetCachedTypesCount()}");
            Console.WriteLine("Note how multiple trees share the same intrinsic data.");
        }
    }
}
