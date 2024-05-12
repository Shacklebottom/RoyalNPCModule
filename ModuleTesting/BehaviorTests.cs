﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain;
using Moq;

namespace ModuleTesting
{
    [TestClass]
    public class BehaviorTests
    {
        private Mock<IProfile> _mockProfile; 

        [TestInitialize]
        public void Initialize_BehaviorTest()
        {
            _mockProfile = new Mock<IProfile>();

            _mockProfile.Setup(p => p.Sociability).Returns(Sociability.Stoic);

            _mockProfile.Setup(p => p.DelayTendency).Returns(DelayTendency.Distracted);
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
        public void Property_ShouldReturnAValue()
        {
            //Arrange
            var behavior = new Behavior(_mockProfile.Object);

            //Act
            var result = behavior.ChanceToSpeak;

            //Assert
            Assert.IsTrue(result > 0);
        }



        //[TestMethod]
        //public void GetDelay_ShouldDoThings()
        //{
        //    //Arrange
        //    var behavior = new Behavior(_mockProfile.Object);

        //    //Act
        //    var result = behavior.GetDelay();

        //    //Assert
            
        //}
    }
}
