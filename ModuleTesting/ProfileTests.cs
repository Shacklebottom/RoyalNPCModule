using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain;

namespace ModuleTesting
{
    [TestClass]
    public class ProfileTests
    {
        private string _name;
        private InherentNature _inherentNature;
        private DelayTendency _delayTendency;

        [TestInitialize]
        public void Initialize_ProfileTest()
        {
            _name = "Turtle Bob";

            _inherentNature = InherentNature.Nonchalant;

            _delayTendency = DelayTendency.Thoughtless;
        }

        [TestMethod]
        public void Constructor_ShouldSetName()
        {
            //Arrange

            var disposition = new Disposition(_inherentNature, _delayTendency);

            //Act
            var profile = new Profile(_name, disposition);

            //Assert
            Assert.AreEqual(_name, profile.Name);
        }

        [TestMethod]
        public void Constructor_ShouldSetDisposition()
        {
            //Arrange
            var disposition = new Disposition(_inherentNature, _delayTendency);

            //Act
            var profile = new Profile(_name, disposition);

            //Assert
            Assert.AreEqual(disposition, profile.Disposition);

        }
    }
}