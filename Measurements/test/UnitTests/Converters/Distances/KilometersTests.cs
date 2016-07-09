using System;
using Xunit;

namespace Savage.Measurements.Converters.Distances
{
    public class KilometersTests
    {
        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 0.001)]
        [InlineData(1000, 1)]
        public void FromMeters_Should_return_expected_values(double meters, double expected)
        {
            var sut = new Kilometers();

            Assert.Equal(expected, sut.FromMeters(meters));
        }

        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 1000)]
        [InlineData(1000, 1000000)]
        public void ToMeters_Should_return_expected_values(double kilometers, double expected)
        {
            var sut = new Kilometers();

            Assert.Equal(expected, sut.ToMeters(kilometers));
        }
    }
}
