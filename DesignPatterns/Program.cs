
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
        DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Demo.Run();
        DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Demo.Run();
        break;
    case "2":
        DesignPatterns.Patterns.Structural.Adapter.Demo.Run();
        DesignPatterns.Patterns.Structural.Bridge.Demo.Run();
        DesignPatterns.Patterns.Structural.Composite.Demo.Run();
        DesignPatterns.Patterns.Structural.Decorator.Demo.Run();
        DesignPatterns.Patterns.Structural.Facade.Demo.Run();
        DesignPatterns.Patterns.Structural.Flyweight.Demo.Run();
        DesignPatterns.Patterns.Structural.Proxy.Demo.Run();
        break;
    case "3":
        DesignPatterns.Patterns.Behavioral.Strategy.Demo.Run();
        DesignPatterns.Patterns.Behavioral.Observer.Demo.Run();
        break;
}


Console.ReadKey();