using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;

namespace ModuleTesting
{
    [TestClass]
    public class RandomGeneratorTests
    {
        [TestMethod]
        public void NextDouble_ReturnsARandomRange_BetweenZeroAndOne()
        {
            //Arrange
            var random = new RandomGenerator();

            //Act
            var result = random.NextDouble();

            //Assert
            //1. that the result is greater than zero, and
            Assert.IsTrue(result > 0);
            //2. that the result is less than one.
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void NextDouble_ReturnsADouble()
        {
            //Arrange
            var random = new RandomGenerator();

            //Act
            var result = random.NextDouble();

            //Assert
            Assert.IsInstanceOfType(result, typeof(double));
        }
    }
}
