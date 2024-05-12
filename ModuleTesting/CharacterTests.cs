using RoyalDomain.Objects;
using RoyalDomain.Interfaces;
using RoyalDomain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ModuleTesting
{
    [TestClass]
    public class CharacterTests
    {
        private Mock<IProfile> _mockProfile;

        private Mock<IBehavior> _mockBehavior;

        private readonly DelayTendency _delayLowEnd = DelayTendency.Focused;

        private readonly DelayTendency _delayHighEnd = DelayTendency.Distracted;

        private readonly Sociability _socialLowEnd = Sociability.Stoic;

        private readonly Sociability _socialHighEnd = Sociability.Chatty;


        [TestInitialize]
        public void Initialize_CharacterTest()
        {
            _mockProfile = new Mock<IProfile>();

            _mockProfile.Setup(p => p.Sociability).Returns(_socialLowEnd);

            _mockProfile.Setup(p => p.DelayTendency).Returns(_delayLowEnd);

            _mockBehavior = new Mock<IBehavior>();

            _mockBehavior.Setup(b => b.Profile).Returns(_mockProfile.Object);

            _mockBehavior.Setup(b => b.ChanceToSpeak).Returns(0.9);

            _mockBehavior.Setup(b => b.WaitLenience).Returns(0.6);
        }

        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange

            //Act
            var character = new Character(_mockProfile.Object, _mockBehavior.Object);

            //Assert
            Assert.AreEqual(_mockProfile.Object, character.Profile);
        }

        [TestMethod]
        public void Constructor_ShouldSetBehavior()
        {
            //Arrange

            //Act
            var character = new Character(_mockProfile.Object, _mockBehavior.Object);

            //Assert
            Assert.AreEqual(_mockBehavior.Object, character.Behavior);
        }
    }
}
