using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Savage.Measurements.UnitsOfMeasure;

namespace Savage.Measurements.Converters.Distances
{
    public class Kilometers : IDistanceConverter
    {
        private const double _meters_per_km = 1000;

        public double FromMeters(double meters)
        {
            return meters / _meters_per_km;
        }

        public double ToMeters(double kilometers)
        {
            return kilometers * _meters_per_km;
        }
    }
}
