using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;
using RoyalDomain.Enums;


namespace ModuleTesting
{
    [TestClass]
    public class ProfileTests
    {
        private readonly Sociability _social = Sociability.Stoic;

        private readonly DelayTendency _delay = DelayTendency.Focused;

        private Profile _profile;

        [TestInitialize]
        public void Initialize_ProfileTest()
        {
            _profile = new Profile(_social, _delay);
        }

        [TestMethod]
        public void Constructor_ShouldSetSociability()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_social, _profile.Sociability);
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendency()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_delay, _profile.DelayTendency);
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
                Assert.IsTrue(_profile.SociabilityWeights.ContainsKey(item));
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
                Assert.AreEqual(typeof(double), item.Value.GetType());
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
                Assert.IsTrue(item.Value < 1);
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
                Assert.IsTrue(item.Value > 0);
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
                Assert.IsTrue(_profile.DelayTendencyWeights.ContainsKey(item));
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
                Assert.AreEqual(typeof(double), item.Value.GetType());
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
                Assert.IsTrue(item.Value < 1.0);
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
                Assert.IsTrue(item.Value > 0.0);
            }
        }
    }
}
