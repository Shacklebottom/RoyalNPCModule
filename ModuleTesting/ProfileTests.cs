using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;
using RoyalDomain.Enums;


namespace ModuleTesting
{
    [TestClass]
    public class ProfileTests
    {
        [TestMethod]
        public void Constructor_ShouldSetSociability()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Focused;

            //Act
            var profile = new Profile(social, delay);

            //Assert
            Assert.AreEqual(social, profile.Sociability);
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendency()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Focused;

            //Act
            var profile = new Profile(social, delay);

            //Assert
            Assert.AreEqual(delay, profile.DelayTendency);
        }
        [TestMethod]
        public void Constructor_ShouldSetSociabilityWeights()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Focused;

            var profile = new Profile(social, delay);

            //Act
            
            //Assert
            //1. that each item in Sociability is in the dictionary, and
            foreach (Sociability item in Enum.GetValues(typeof(Sociability)))
            {
                Assert.IsTrue(profile.SociabilityWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in profile.SociabilityWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendencyWeights()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Focused;

            var profile = new Profile(social, delay);

            //Act


            //Assert
            //1. that each item in DelayTendency is in the dictionary, and
            foreach (DelayTendency item in Enum.GetValues(typeof(DelayTendency)))
            {
                Assert.IsTrue(profile.DelayTendencyWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in profile.DelayTendencyWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }
    }
}
