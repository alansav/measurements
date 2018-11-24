namespace Savage.Measurements.Converters
{
    public interface IDistanceConverter
    {
        double FromMeters(double meters);
        double ToMeters(double value);
    }
}
