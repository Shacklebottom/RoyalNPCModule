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
    }
}
