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

        private readonly DelayTendency _delayLowEnd = DelayTendency.Focused;

        private readonly DelayTendency _delayHighEnd = DelayTendency.Distracted;

        private readonly Sociability _socialLowEnd = Sociability.Stoic;

        private readonly Sociability _socialHighEnd = Sociability.Chatty;

        private Behavior _behavior;

        [TestInitialize]
        public void Initialize_BehaviorTest()
        {
            _mockProfile = new Mock<IProfile>();

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            var testDelayDictionary = new Dictionary<DelayTendency, double>
            {
                { _delayLowEnd, 0.1 },
                { _delayHighEnd, 0.9 },
            };
            _mockProfile.Setup(p => p.DelayTendencyWeights).Returns(testDelayDictionary);

            var testSociabilityDictionary = new Dictionary<Sociability, double>
            {
                { _socialLowEnd, 0.1},
                { _socialHighEnd, 0.9 } 
            };
            _mockProfile.Setup(p => p.SociabilityWeights).Returns(testSociabilityDictionary);

            _behavior = new Behavior(_mockProfile.Object);
        }

        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_mockProfile.Object, _behavior.Profile);
        }

        [TestMethod]
        public void ChanceToSpeak_UsesWeightsDictionaries()
        {
            //Arrange
            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            //Act
            var expectedResult = _behavior.ChanceToSpeak;

            //Assert
            var actualResult =
                    _mockProfile.Object.SociabilityWeights[_mockProfile.Object.Sociability] * 0.7 +
                    _mockProfile.Object.DelayTendencyWeights[_mockProfile.Object.DelayTendency] * 0.3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ChanceToSpeak_ReturnsADouble()
        {
            //Arrange

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.AreEqual(typeof(double), result.GetType());
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_LessThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldReturn_GreaterThanZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void WaitLenience_UsesWeightsDictionaries()
        {
            //Arrange
            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            //Act
            var expectedResult = _behavior.WaitLenience;

            //Assert
            var actualResult =
                    _mockProfile.Object.DelayTendencyWeights[_mockProfile.Object.DelayTendency] * 0.6 +
                    _mockProfile.Object.SociabilityWeights[_mockProfile.Object.Sociability] * 0.4;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WaitLenience_ReturnsADouble()
        {
            //Arrange

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.AreEqual(typeof(double), result.GetType());
        }

        [TestMethod]
        public void WaitLenience_ShouldReturn_LessThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void WaitLenience_ShouldReturn_GreaterThanZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            _behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = _behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result > 0);
        }
    }
}
