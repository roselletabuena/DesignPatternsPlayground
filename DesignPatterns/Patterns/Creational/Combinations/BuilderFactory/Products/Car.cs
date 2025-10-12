

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products
{
    record Car(
        CarType Type,
        string Model,
        EngineType Engine,
        TransmissionType Transmission,
        int Doors,
        IReadOnlyList<string> Features
        );
}
