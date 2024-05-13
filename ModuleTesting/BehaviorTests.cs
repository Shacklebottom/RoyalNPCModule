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
        }

        [TestMethod]
        public void Constructor_ShouldSetSociabilityWeights()
        {
            //Arrange

            //Act
            var behavior = new Behavior(_mockProfile.Object);

            //Assert
            //1. that each item in Sociability is in the dictionary, and
            foreach (Sociability item in Enum.GetValues(typeof(Sociability)))
            {
                Assert.IsTrue(behavior.SociabilityWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in behavior.SociabilityWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendencyWeights()
        {
            //Arrange

            //Act
            var behavior = new Behavior(_mockProfile.Object);

            //Assert
            //1. that each item in DelayTendency is in the dictionary, and
            foreach (DelayTendency item in Enum.GetValues(typeof(DelayTendency)))
            {
                Assert.IsTrue(behavior.DelayTendencyWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in behavior.DelayTendencyWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
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
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_ExactlyZero()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result != 0);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_GreaterThanOne()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void ChanceToSpeak_ShouldNotReturn_ExactlyOne()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(mockProfile.Object);

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
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_ExactlyZero()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result != 0);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_GreaterThanOne()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result < 1);
        }

        [TestMethod]
        public void WaitLenience_ShouldNotReturn_ExactlyOne()
        {
            //Arrange
            Mock<IProfile> mockProfile = new Mock<IProfile>();

            mockProfile.Setup(p => p.DelayTendency).Returns(_delayHighEnd);

            mockProfile.Setup(p => p.Sociability).Returns(_socialHighEnd);

            var behavior = new Behavior(mockProfile.Object);

            //Act
            var result = behavior.WaitLenience;

            //Assert
            Assert.IsTrue(result != 1);
        }
    }
}
