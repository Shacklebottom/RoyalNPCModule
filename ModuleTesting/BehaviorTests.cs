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
                { _socialLowEnd, 0.1 },
                { _socialHighEnd, 0.9 } 
            };
            _mockProfile.Setup(p => p.SociabilityWeights).Returns(testSociabilityDictionary);
        }



        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange

            //Act
            var behavior = new Behavior(_mockProfile.Object);

            //Assert
            Assert.AreEqual(_mockProfile.Object, behavior.Profile);
        }

        [TestMethod]
        public void ChanceToSpeak_ReturnsADouble()
        {
            //Arrange
            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_LessThanZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_ExactlyZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result != 0);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_GreaterThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_ExactlyOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result != 1);
        }

        [TestMethod]
        public void WaitLenience_ReturnsADouble()
        {
            //Arrange
            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_LessThanZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_ExactlyZero()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result != 0);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_GreaterThanOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_ExactlyOne()
        {
            //Arrange
            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            _mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result != 1);
        }
    }
}
