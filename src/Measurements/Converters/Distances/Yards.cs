namespace Savage.Measurements.Converters.Distances
{
    public class Yards : IDistanceConverter
    {
        private const double _meters_per_yard = 0.9144;

        public double FromMeters(double meters)
        {
            return meters / _meters_per_yard;
        }

        public double ToMeters(double yards)
        {
            return yards * _meters_per_yard;
        }
    }
}
