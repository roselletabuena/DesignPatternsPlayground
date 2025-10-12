
using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders
{
    internal abstract class CarBuilderBase : ICarBuilder
    {
        protected string _model = string.Empty;
        protected EngineType? _engine;
        protected TransmissionType? _transmission;
        protected int? _doors;
        protected readonly List<string> _features = new();

        protected abstract CarType CarType { get; }

        public ICarBuilder SetModel(string model)
        {
            if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Model cannot be empty.", nameof(model));
            _model = model.Trim();
            return this;
        }
        
        public ICarBuilder SetEngine(EngineType engine)
        {
            _engine = engine; 
            return this;
        }

        public ICarBuilder SetTransmission(TransmissionType transmission)
        {
            _transmission = transmission; return this;
            return this;
        }

        public ICarBuilder SetDoors(int doors)
        {
            if (doors <= 0) throw new ArgumentOutOfRangeException(nameof(doors), "Doors must be positive.");
            _doors = doors;
            return this;
        }

        public ICarBuilder AddFeature(string feature)
        {
            if (string.IsNullOrWhiteSpace(feature)) throw new ArgumentException("Feature cannot be empty.", nameof(feature));
            _features.Add(feature.Trim());
            return this;
        }

        protected virtual void Validate()
        {
            if (string.IsNullOrWhiteSpace(_model)) throw new InvalidOperationException("Model must be set.");
            if (_engine is null) throw new InvalidOperationException("Engine must be set.");
            if (_transmission is null) throw new InvalidOperationException("Transmission must be set.");
            if (_doors is null) throw new InvalidOperationException("Doors must be set.");
        }

        public virtual Car Build()
        {
            Validate();

            return new Car
            (
                CarType,
                _model,
                _engine!.Value,
                _transmission!.Value,
                _doors!.Value,
                _features.ToList().AsReadOnly()
            );
        }

    }
}
