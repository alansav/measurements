using System;
using Xunit;

namespace Savage.Measurements.Converters.Distances
{
    public class YardsTests
    {
        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 1.093613298)]
        [InlineData(1000, 1093.613298338)]
        public void FromMeters_Should_return_expected_values(double meters, double expected)
        {
            var sut = new Yards();

            Assert.Equal(expected, Math.Round(sut.FromMeters(meters), 9));
        }

        [Theory()]
        [InlineData(0, 0)]
        [InlineData(1, 0.9144)]
        [InlineData(1000, 914.4)]
        public void ToMeters_Should_return_expected_values(double feet, double expected)
        {
            var sut = new Yards();

            Assert.Equal(expected, Math.Round(sut.ToMeters(feet), 9));
        }
    }
}
