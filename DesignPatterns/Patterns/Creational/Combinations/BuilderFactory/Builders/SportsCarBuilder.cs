

using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders
{
    internal class SportsCarBuilder : CarBuilderBase
    {
        protected override CarType CarType => CarType.Sports;

        public SportsCarBuilder() {

            _doors = 2;
            _engine = EngineType.V8;
            _transmission = TransmissionType.DualClutch;
            _features.Add("Sport Suspension");
            _features.Add("Performance Brakes");
        }


        protected override void Validate()
        {
            base.Validate();
            if (_doors > 2) throw new InvalidOperationException("Sports car typically has 2 doors.");
        }

    }
}
