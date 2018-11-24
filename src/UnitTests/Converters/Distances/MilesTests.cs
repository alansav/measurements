using System;
using Xunit;

namespace Savage.Measurements.Converters.Distances
{
    public class MilesTests
    {
        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 0.000621371)]
        [InlineData(1000, 0.621371192)]
        public void FromMeters_Should_return_expected_values(double meters, double expected)
        {
            var sut = new Miles();

            Assert.Equal(expected, Math.Round(sut.FromMeters(meters), 9));
        }

        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 1609.344)]
        [InlineData(1000, 1609344)]
        public void ToMeters_Should_return_expected_values(double miles, double expected)
        {
            var sut = new Miles();

            Assert.Equal(expected, Math.Round(sut.ToMeters(miles), 9));
        }
    }
}

