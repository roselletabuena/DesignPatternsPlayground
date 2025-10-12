
Console.WriteLine("=== Design Patterns Showcase ===");
Console.WriteLine("1. Creational");
Console.WriteLine("2. Behavioral");
Console.WriteLine("3. Structural");
Console.WriteLine("Choose a pattern to run:");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        DesignPatterns.Patterns.Creational.FactoryMethod.Demo.Run();
        DesignPatterns.Patterns.Creational.AbstractFactory.Demo.Run();
        DesignPatterns.Patterns.Creational.Builder.Demo.Run();
        DesignPatterns.Patterns.Creational.Prototype.Demo.Run();
        DesignPatterns.Patterns.Creational.Singleton.Demo.Run();

        Console.WriteLine("====================");

        DesignPatterns.Patterns.Creational.Combinations.SingletonFactory.Demo.Run();
        break;
    case "2":
        Console.WriteLine("Placeholder Creational");
        break;
    case "3":
        Console.WriteLine("Placeholder Structural");
        break;
}


Console.ReadKey();