using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Interfaces;
using RoyalDomain.Enums;
using RoyalDomain.Objects;
using Moq;

namespace ModuleTesting
{
    [TestClass]
    public class BehaviorTests
    {
        private Mock<IProfile> _mockProfile;

        private readonly double _delayLowEnd = 0.1;

        private readonly double _delayHighEnd = 0.9;

        private readonly double _socialLowEnd = 0.1;

        private readonly double _socialHighEnd = 0.9;

        private Behavior _behavior;

        [TestInitialize]
        public void Initialize_BehaviorTest()
        {
            _mockProfile = new Mock<IProfile>();

            _mockProfile.Setup(p => p.SocialValue).Returns(_socialLowEnd);

            _mockProfile.Setup(p => p.DelayValue).Returns(_delayLowEnd);

            _behavior = new Behavior(_mockProfile.Object);
        }

        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_mockProfile.Object, _behavior.Profile,
                "the constructor is not setting the Profile field");
        }

        [TestMethod]
        public void ChanceToSpeak_ReturnsADouble()
        {
            //Arrange

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.AreEqual(typeof(double), result.GetType(),
                $"ChanceToSpeak returned as type {result.GetType()} when double was expected");
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldReturn_LessThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayValue).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.SocialValue).Returns(_socialHighEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result < 1,
                $"ChanceToSpeak returned greater than one; result: {result}");
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldReturn_GreaterThanZero()
        {
            //Arrange
            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result > 0,
                $"ChanceToSpeak returned less than zero; result: {result}");
        }

        [TestMethod]
        public void WaitLenience_ReturnsADouble()
        {
            //Arrange

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.AreEqual(typeof(double), result.GetType(),
                $"WaitLenience returned as type {result.GetType()} when double was expected");
        }

        [TestMethod]
        public void WaitLenience_ShouldReturn_LessThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayValue).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.SocialValue).Returns(_socialHighEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result < 1,
                $"WaitLenience returned greater than one; result: {result}");
        }

        [TestMethod]
        public void WaitLenience_ShouldReturn_GreaterThanZero()
        {
            //Arrange
            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result > 0,
                $"WaitLenience returned less than zero; result: {result}");
        }
    }
}
