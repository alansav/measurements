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
    }
}
