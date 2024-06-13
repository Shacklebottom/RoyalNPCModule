using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;
using RoyalDomain.Enums;

#pragma warning disable CS8618

namespace ModuleTesting
{
    [TestClass]
    public class ProfileTests
    {
        private readonly Sociability _social = Sociability.Stoic;

        private readonly DelayTendency _delay = DelayTendency.Focused;

        private readonly FidgetTendency _fidget = FidgetTendency.Relaxed;

        private Profile _profile;

        [TestInitialize]
        public void Initialize_ProfileTest()
        {
            _profile = new Profile(_social, _delay, _fidget);
        }

        [TestMethod]
        public void SocialValue_ShouldYieldWeight_BasedOnEnum()
        {
            //Arrange


            //Act


            //Assert
            var socialWeight = _profile.SociabilityWeights[_social];
            Assert.AreEqual(socialWeight, _profile.SocialValue,
                $"SocialValue was: {_profile.SocialValue} when {socialWeight} was expected");
        }

        [TestMethod]
        public void DelayValue_ShouldYieldWeight_BasedOnEnum()
        {
            //Arrange


            //Act


            //Assert
            var delayWeight = _profile.DelayTendencyWeights[_delay];
            Assert.AreEqual(delayWeight, _profile.DelayValue,
                $"DelayValue was: {_profile.DelayValue} when {delayWeight} was expected");
        }

        [TestMethod]
        public void FidgetValue_ShouldYieldWeight_BasedOnEnum()
        {
            //Arrange

            //Act

            //Assert
            var fidgetWeight = _profile.FidgetTendencyWeights[_fidget];
            Assert.AreEqual(fidgetWeight, _profile.FidgetValue,
                $"FidgetValue was: {_profile.FidgetValue} when {fidgetWeight} was expected");
        }

        [TestMethod]
        public void SociabilityWeights_ShouldImplement_EachEnumElementAsKey()
        {
            //Arrange

            //Act
            
            //Assert
            //1. that each item in Sociability is in the dictionary
            foreach (Sociability item in Enum.GetValues(typeof(Sociability)))
            {
                Assert.IsTrue(_profile.SociabilityWeights.ContainsKey(item), 
                    $"dictionary does not contain key: {item}");
            }
        }

        [TestMethod]
        public void SociabilityWeights_ShouldImplement_DoubleAsValue()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.SociabilityWeights)
            {
                Assert.AreEqual(typeof(double), item.Value.GetType(), 
                    $"element is of type {item.Value.GetType()}, when double was expected");
            }
        }

        [TestMethod]
        public void SociabilityWeights_ValueShouldBe_LessThanOne()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.SociabilityWeights)
            {
                Assert.IsTrue(item.Value < 1, 
                    $"element: {item.Key} has a value greater than one");
            }
        }

        [TestMethod]
        public void SociabilityWeights_ValueShouldBe_GreaterThanZero()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.SociabilityWeights)
            {
                Assert.IsTrue(item.Value > 0, 
                    $"element: {item.Key} has a value less than 0");
            }
        }

        [TestMethod]
        public void DelayTendencyWeights_ShouldImplement_EachEnumElementAsKey()
        {
            //Arrange

            //Act

            //Assert
            //1. that each item in DelayTendency is in the dictionary
            foreach (DelayTendency item in Enum.GetValues(typeof(DelayTendency)))
            {
                Assert.IsTrue(_profile.DelayTendencyWeights.ContainsKey(item), 
                    $"dictionary does not contain key: {item}");
            }
        }

        [TestMethod]
        public void DelayTendencyWeights_ShouldImplement_DoubleAsValue()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.DelayTendencyWeights)
            {
                Assert.AreEqual(typeof(double), item.Value.GetType(),
                    $"element is of type {item.Value.GetType()}, when double was expected");
            }
        }

        [TestMethod]
        public void DelayTendencyWeights_ValueShouldBe_LessThanOne()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.DelayTendencyWeights)
            {
                Assert.IsTrue(item.Value < 1.0, 
                    $"element: {item.Key} has a value greater than one");
            }
        }

        [TestMethod]
        public void DelayTendencyWeights_ValueShouldBe_GreaterThanZero()
        {
            //Arrange

            //Act

            //Assert
            foreach (var item in _profile.DelayTendencyWeights)
            {
                Assert.IsTrue(item.Value > 0.0, 
                    $"element: {item.Key} has a value less than zero");
            }
        }

        [TestMethod]
        public void FidgetTendencyWeights_ShouldImplement_EachEnumElementAsKey()
        {
            //Arrange

            //Act

            //Assert
            foreach (FidgetTendency item in Enum.GetValues(typeof(FidgetTendency)))
            {
                Assert.IsTrue(_profile.FidgetTendencyWeights.ContainsKey(item), 
                    $"dictionary does not contain key: {item}");
            }
        }

        [TestMethod]
        public void FidgetTendencyWeights_ShouldImplement_DoubleAsValue()
        {
            //Arrange


            //Act


            //Assert
            foreach (var item in _profile.FidgetTendencyWeights)
            {
                Assert.AreEqual(typeof(double), item.Value.GetType(),
                    $"element is of type {item.Value.GetType()}, when double was expected");
            }
        }

        [TestMethod]
        public void FidgetTendencyWeights_ValueShouldBe_LessThanOne()
        {
            //Arrange


            //Act


            //Assert
            foreach (var item in _profile.FidgetTendencyWeights)
            {
                Assert.IsTrue(item.Value < 1.0,
                    $"element: {item.Key} has a value greater than one");
            }

        }

        [TestMethod]
        public void FidgetTendencyWeights_ValueShouldBe_GreaterThanZero()
        {
            //Arrange


            //Act


            //Assert
            foreach (var item in _profile.FidgetTendencyWeights)
            {
                Assert.IsTrue(item.Value > 0.0,
                    $"element: {item.Key} has a value less than zero");
            }
        }
    }
}
