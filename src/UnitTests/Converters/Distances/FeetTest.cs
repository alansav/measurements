using System;
using Xunit;

namespace Savage.Measurements.Converters.Distances
{
    public class FeetTests
    {
        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 3.280839895)]
        [InlineData(1000, 3280.839895013)]
        public void FromMeters_Should_return_expected_values(double meters, double expected)
        {
            var sut = new Feet();

            Assert.Equal(expected, Math.Round(sut.FromMeters(meters), 9));
        }

        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 0.3048)]
        [InlineData(1000, 304.8)]
        public void ToMeters_Should_return_expected_values(double feet, double expected)
        {
            var sut = new Feet();

            Assert.Equal(expected, Math.Round(sut.ToMeters(feet), 9));
        }
    }
}
