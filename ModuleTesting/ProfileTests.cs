
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain;


namespace ModuleTesting
{
    [TestClass]
    public class ProfileTests
    {
        [TestMethod]
        public void Constructor_ShouldAssignSociability()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Distracted;

            //Act
            var profile = new Profile(social, delay);

            //Assert
            Assert.AreEqual(social, profile.Sociability);
        }

        [TestMethod]
        public void Constructor_ShouldAssignDelayTendency()
        {
            //Arrange
            var social = Sociability.Stoic;

            var delay = DelayTendency.Distracted;

            //Act
            var profile = new Profile(social, delay);

            //Assert
            Assert.AreEqual(delay, profile.DelayTendency);

        }
    }
}
