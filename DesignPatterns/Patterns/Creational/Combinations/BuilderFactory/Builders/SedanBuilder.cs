using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders
{
    internal class SedanBuilder : CarBuilderBase
    {
        protected override CarType CarType => CarType.Sedan;

        public SedanBuilder() {
            _doors = 4;
            _engine = EngineType.Inline4;
            _transmission = TransmissionType.Automatic;
        }

        protected override void Validate()
        {
            base.Validate();
           
            if (_doors < 4) throw new InvalidOperationException("Sedan must have at least 4 doors.");
        }

    }
}
