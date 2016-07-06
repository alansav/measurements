namespace Savage
{
    public class Distance
    {
        private Distance(double meters)
        {
            _meters = meters;
        }

        public static Distance NewFromMeters(double meters)
        {
            return new Distance(meters);
        }

        private readonly double _meters;

        public double Meters => _meters;

        public double Kilometers => _meters / 1000;

        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }

        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }
    }
}
