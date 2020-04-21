using System;
using Xunit;
//Moq is a NuGet.
using Moq;

//This is the unit test.
namespace Interface3_2.Test
{
    public class DestFanTest
    {
        [Fact]
        public void PowerLowerThan_0_OK()
        {
            var fan = new DeskFan(new PowerSupplyLowerThan_0());
            var result = fan.Work();
            var expected = "Can't work";
            Assert.Equal(result, expected);
        }

        [Fact]
        public void PowerHigherThan_200_Explode()
        {
            var fan = new DeskFan(new PowerSupplyHigherThan_200());
            var result = fan.Work();
            var expected = "Explode!";
            Assert.Equal(result, expected);
        }

        [Fact]
        public void Power_150_Fine()
        {
            //Using Mock can help to save the redundant steps to create a specific class for test.
            var mock = new Mock<IPowerSupply>();

            //Lambda expression here means
            //first, create an instance with a method called "GetPower".
            //second, set the return value of that method to be 150;
            mock.Setup(ps => ps.GetPower()).Returns(() => 150);
            var fan = new DeskFan(mock.Object);
            var result = fan.Work();
            var expected = "Fine";
            Assert.Equal(result, expected);
        }
    }

    class PowerSupplyLowerThan_0 : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }

    class PowerSupplyHigherThan_200 : IPowerSupply
    {
        public int GetPower()
        {
            return 220;
        }
    }
}
