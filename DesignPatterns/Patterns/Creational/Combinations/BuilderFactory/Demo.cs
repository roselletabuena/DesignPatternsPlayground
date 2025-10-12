
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Factory;
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Director;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Builder + Factory Method: Car Builder Demo ===\n");

            ICarBuilerFactory factory = new CarBuilderFactory();

            var sedanBuilder = factory.CreateBuilder(CarType.Sedan);

            // Option A: Use Director for pre-defined assembly sequences
            var director = new CarDirector(sedanBuilder);
            director.ConstructComfortableFamilySedan("FamilyLux 2025");
            var familySedan = sedanBuilder.Build();

            Console.WriteLine($"Built {familySedan.Type} - {familySedan.Model}");
            Console.WriteLine($"Engine: {familySedan.Engine}, Transmission: {familySedan.Transmission}, Doors: {familySedan.Doors}");
            Console.WriteLine($"Features: {string.Join(", ", familySedan.Features)}");
            Console.WriteLine();

            // --- Client uses builder directly for custom build
            var sportBuilder = factory.CreateBuilder(CarType.Sports)
                .SetModel("BladeZ R")
                .SetEngine(EngineType.V8)
                .SetTransmission(TransmissionType.DualClutch)
                .SetDoors(2)
                .AddFeature("Carbon Fiber Hood")
                .AddFeature("Launch Control");

            var sportCar = sportBuilder.Build();

            Console.WriteLine($"Built {sportCar.Type} - {sportCar.Model}");
            Console.WriteLine($"Engine: {sportCar.Engine}, Transmission: {sportCar.Transmission}, Doors: {sportCar.Doors}");
            Console.WriteLine($"Features: {string.Join(", ", sportCar.Features)}");
            Console.WriteLine();

            // --- SUV example with default values from builder + small customization
            var suvBuilder = factory.CreateBuilder(CarType.Suv)
                .SetModel("Explorer X")
                .AddFeature("Tow Package");
            var suv = suvBuilder.Build();

            Console.WriteLine($"Built {suv.Type} - {suv.Model}");
            Console.WriteLine($"Features: {string.Join(", ", suv.Features)}");
        }
    }
}
