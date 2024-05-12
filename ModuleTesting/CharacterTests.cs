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
        private Mock<IBehavior> _mockBehavior;

        [TestInitialize]
        public void Initialize_CharacterTest()
        {
            _mockBehavior = new Mock<IBehavior>();

            _mockBehavior.Setup(b => b.ChanceToSpeak).Returns(0.9);

            _mockBehavior.Setup(b => b.WaitLenience).Returns(0.6);
        }

        [TestMethod]
        public void Constructor_ShouldSetBehavior()
        {
            //Arrange

            //Act
            var character = new Character(_mockBehavior.Object);

            //Assert
            Assert.AreEqual(_mockBehavior.Object, character.Behavior);
        }
    }
}
