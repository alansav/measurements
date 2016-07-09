using Xunit;

namespace Savage.Measurements
{
    public class DistanceTest
    {
        [Fact]
        public void Constructor_Should_assign_value()
        {
            var meters = 5000;

            //Act
            var sut = new Distance(meters, UnitsOfMeasure.Distances.Meters);

            //Assert
            Assert.Equal(meters, sut.Value);
        }

        [Fact]
        public void Constructor_Should_assign_UnitOfMeasure()
        {
            var meters = 5000;

            //Act
            var sut = new Distance(meters, UnitsOfMeasure.Distances.Meters);

            //Assert
            Assert.Equal(UnitsOfMeasure.Distances.Meters, sut.UnitOfMeasure);
        }

        [Fact]
        public void ConvertMilesToKilometers()
        {
            var miles = new Distance(1, UnitsOfMeasure.Distances.Miles);

            //Act
            var sut = miles.Convert(UnitsOfMeasure.Distances.Kilometers);

            //Assert
            Assert.Equal(1.609344, sut.Value);
            Assert.Equal(UnitsOfMeasure.Distances.Kilometers, sut.UnitOfMeasure);
        }

        [Fact]
        public void ConvertKilometersToMiles()
        {
            var km = new Distance(1, UnitsOfMeasure.Distances.Kilometers);

            //Act
            var sut = km.Convert(UnitsOfMeasure.Distances.Miles);

            //Assert
            Assert.Equal(0.621371192237334, sut.Value);
            Assert.Equal(UnitsOfMeasure.Distances.Miles, sut.UnitOfMeasure);
        }
    }
}
