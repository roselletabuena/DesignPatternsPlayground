

using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders;
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Factory
{
    interface ICarBuilerFactory
    {
        ICarBuilder CreateBuilder(CarType type);
    }
    internal sealed class CarBuilderFactory : ICarBuilerFactory
    {
        public ICarBuilder CreateBuilder(CarType type)
        {
            return type switch
            { CarType.Sedan => new SedanBuilder(),
                CarType.Suv => new SuvBuilder(),
                CarType.Sports => new SportsCarBuilder(),
             _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unsupported car type: {type}")
            };
        }
    }
}
