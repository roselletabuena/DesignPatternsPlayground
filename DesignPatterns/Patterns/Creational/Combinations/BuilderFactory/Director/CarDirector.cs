
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders;
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Director
{
    internal class CarDirector
    {
        private readonly ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructComfortableFamilySedan(string model)
        {
            _builder
               .SetModel(model)
               .SetEngine(EngineType.Inline4)
               .SetTransmission(TransmissionType.Automatic)
               .SetDoors(4)
               .AddFeature("Cruise Control")
               .AddFeature("Rear Camera");
        }

        public void ConstructTrackReadySportsCar(string model)
        {
            _builder
                .SetModel(model)
                .SetEngine(EngineType.V8)
                .SetTransmission(TransmissionType.DualClutch)
                .SetDoors(2)
                .AddFeature("Roll Cage")
                .AddFeature("Racing Seats");
        }
    }
}
