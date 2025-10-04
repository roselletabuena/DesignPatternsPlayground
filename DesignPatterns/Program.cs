
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
        break;
    case "2":
        Console.WriteLine("Placeholder Creational");
        break;
    case "3":
        Console.WriteLine("Placeholder Structural");
        break;
}


Console.ReadKey();