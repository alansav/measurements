using System;

namespace Savage.Measurements
{
    public class Distance
    {
        public readonly double Value;
        public readonly UnitsOfMeasure.Distances UnitOfMeasure;

        public Distance(double value, UnitsOfMeasure.Distances unitOfMeasure)
        {
            Value = value;
            UnitOfMeasure = unitOfMeasure;
        }

        public Distance Convert(UnitsOfMeasure.Distances convertingTo)
        {
            var meters = UnitOfMeasure == UnitsOfMeasure.Distances.Meters ? Value : GetDistanceConverter(UnitOfMeasure).ToMeters(Value);

            if (convertingTo == UnitsOfMeasure.Distances.Meters)
                return new Distance(meters, UnitsOfMeasure.Distances.Meters);
            
            var convertor = GetDistanceConverter(convertingTo);
            return new Distance(convertor.FromMeters(meters), convertingTo);
        }

        private Converters.IDistanceConverter GetDistanceConverter(UnitsOfMeasure.Distances unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case UnitsOfMeasure.Distances.Feet:
                    return new Converters.Distances.Feet();
                case UnitsOfMeasure.Distances.Kilometers:
                    return new Converters.Distances.Kilometers();
                case UnitsOfMeasure.Distances.Meters:
                    return null;
                case UnitsOfMeasure.Distances.Miles:
                    return new Converters.Distances.Miles();
                case UnitsOfMeasure.Distances.Yards:
                    return new Converters.Distances.Yards();
                default:
                    throw new NotImplementedException(nameof(unitOfMeasure));
            }
        }
    }
}
