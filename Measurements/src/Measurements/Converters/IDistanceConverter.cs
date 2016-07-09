using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savage.Measurements.Converters
{
    public interface IDistanceConverter
    {
        double FromMeters(double meters);
        double ToMeters(double value);
    }
}
