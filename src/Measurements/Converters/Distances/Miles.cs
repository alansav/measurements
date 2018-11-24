namespace Savage.Measurements.Converters.Distances
{
    public class Miles : IDistanceConverter
    {
        private const double _meters_per_mile = 1609.344;

        public double FromMeters(double kilometers)
        {
            return kilometers / _meters_per_mile;
        }

        public double ToMeters(double miles)
        {
            return miles * _meters_per_mile;
        }
    }
}
