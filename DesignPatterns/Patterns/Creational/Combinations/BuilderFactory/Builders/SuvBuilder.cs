using DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Combinations.BuilderFactory.Builders
{
    internal class SuvBuilder : CarBuilderBase
    {

        protected override CarType CarType => CarType.Suv;

        public SuvBuilder() 
        {
            _doors = 5;
            _engine = EngineType.V6;
            _transmission = TransmissionType.Automatic;
            _features.Add("All-Wheel Drive");
        }

        protected override void Validate()
        {
            base.Validate();
            if (_doors < 4) throw new InvalidOperationException("SUV usually has at least 4 doors.");
        }

    }
}
