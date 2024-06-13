using RoyalDomain.Objects;
using RoyalDomain.Interfaces;
using RoyalDomain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

#pragma warning disable CS8618

namespace ModuleTesting
{
    [TestClass]
    public class CharacterTests
    {
        private Mock<IBehavior> _mockBehavior;

        private Mock<IRandomGenerator> _mockRandom;

        private Character _character;

        [TestInitialize]
        public void Initialize_CharacterTest()
        {
            _mockBehavior = new Mock<IBehavior>();

            _mockRandom = new Mock<IRandomGenerator>();

            _mockRandom.Setup(r => r.NextDouble()).Returns(0.5);

            _character = new Character(_mockBehavior.Object, _mockRandom.Object);
        }

        [TestMethod]
        public void Constructor_ShouldSetBehavior()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_mockBehavior.Object, _character.Behavior, 
                "the constructor is not setting the Behavior field");
        }

        [TestMethod]
        public void Constructor_ShouldSetRandom()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_mockRandom.Object, _character.Random, 
                "the constructor is not setting the Random field");
        }

        [TestMethod]
        public void ShallCharacterSpeak_ShouldCallNextDouble_ExactlyOnce()
        {
            //Arrange

            //Act
            var result = _character.ShallCharacterSpeak();

            //Assert
            _mockRandom.Verify(r => r.NextDouble(), Times.Once, 
                "NextDouble() was not called exactly once");
        }

        [TestMethod]
        public void ShallCharacterSpeak_IfValueGreaterThanChanceToSpeak_ReturnFalse()
        {
            //Arrange
            _mockRandom.Setup(r => r.NextDouble()).Returns(0.4);

            _mockBehavior.Setup(b => b.ChanceToSpeak).Returns(0.3);

            //Act
            var result = _character.ShallCharacterSpeak();

            //Assert
            Assert.IsFalse(result, 
                $"ShallCharacterSpeak() returned {result} when false was expected");
        }

        [TestMethod]
        public void ShallCharacterSpeak_IfValueLessThanChanceToSpeak_ReturnTrue()
        {
            //Arrange
            _mockRandom.Setup(r => r.NextDouble()).Returns(0.2);

            _mockBehavior.Setup(b => b.ChanceToSpeak).Returns(0.3);

            //Act
            var result = _character.ShallCharacterSpeak();

            //Assert
            Assert.IsTrue(result, 
                $"ShallCharacterSpeak() returned {result} when true was expected");
        }

        [TestMethod]
        public void ShallCharacterSpeak_IfValueEqualsChanceToSpeak_ReturnTrue()
        {
            //Arrange
            _mockRandom.Setup(r => r.NextDouble()).Returns(0.2);

            _mockBehavior.Setup(b => b.ChanceToSpeak).Returns(0.2);


            //Act
            var result = _character.ShallCharacterSpeak();

            //Assert
            Assert.IsTrue(result, 
                $"ShallCharacterSpeak() returned {result} when true was expected");
        }
    }
}
