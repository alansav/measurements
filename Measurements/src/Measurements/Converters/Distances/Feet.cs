using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savage.Measurements.Converters.Distances
{
    public class Feet : IDistanceConverter
    {
        private const double _meters_per_feet = 0.3048;

        public double FromMeters(double meters)
        {
            return meters / _meters_per_feet;
        }

        public double ToMeters(double feet)
        {
            return feet * _meters_per_feet;
        }
    }
}
