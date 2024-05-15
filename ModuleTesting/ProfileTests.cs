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
        public void Constructor_ShouldSetSociabilityWeights()
        {
            //Arrange
            //Act
            
            //Assert
            //1. that each item in Sociability is in the dictionary, and
            foreach (Sociability item in Enum.GetValues(typeof(Sociability)))
            {
                Assert.IsTrue(_profile.SociabilityWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in _profile.SociabilityWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendencyWeights()
        {
            //Arrange

            //Act

            //Assert
            //1. that each item in DelayTendency is in the dictionary, and
            foreach (DelayTendency item in Enum.GetValues(typeof(DelayTendency)))
            {
                Assert.IsTrue(_profile.DelayTendencyWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in _profile.DelayTendencyWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }
    }
}
