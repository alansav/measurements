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
