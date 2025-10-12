using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders
{
    internal interface ICarBuilder
    {
        ICarBuilder SetModel(string model);
        ICarBuilder SetEngine(EngineType engine);
        ICarBuilder SetTransmission(TransmissionType transimission);
        ICarBuilder SetDoors(int doors);
        ICarBuilder AddFeature(string features);
        Car Build();
    }
}
