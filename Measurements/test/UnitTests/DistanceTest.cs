using Xunit;

namespace Savage
{
    public class DistanceTest
    {
        [Fact]
        public void NewFromMeters()
        {
            var meters = 5000;

            //Act
            var sut = Distance.NewFromMeters(meters);

            //Assert
            Assert.Equal(meters, sut.Meters);
            Assert.Equal((double)meters / 1000, sut.Kilometers);
        }

        [Fact]
        public void NewFromKilometers_Should_InitializeCorrectly()
        {
            var kilometers = 5;

            //Act
            var sut = Distance.NewFromKilometers(kilometers);

            //Assert
            Assert.Equal(kilometers, sut.Kilometers);
            Assert.Equal(kilometers * 1000, sut.Meters);
        }

        [Fact]
        public void ConvertMilesToKilometers()
        {
            //Act
            var km = Distance.ConvertMilesToKilometers(1);

            //Assert
            Assert.Equal(1.609344, km);
        }

        [Fact]
        public void ConvertKilometersToMiles()
        {
            //Act
            var miles = Distance.ConvertKilometersToMiles(1);

            //Assert
            Assert.Equal(0.621371192, miles);
        }

        [Fact]
        public void ConvertKilometersToMeters()
        {
            //Act
            var meters = Distance.ConvertKilometersToMeters(5);

            //Assert
            Assert.Equal(5000, meters);
        }

        [Fact]
        public void ConvertMetersToKilometers()
        {
            //Act
            var kilometers = Distance.ConvertMetersToKilometers(5000);

            //Assert
            Assert.Equal(5, kilometers);
        }
    }
}
