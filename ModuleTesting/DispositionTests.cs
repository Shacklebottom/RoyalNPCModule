using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain;

namespace ModuleTesting
{
    [TestClass]
    public class DispositionTests
    {
        private InherentNature _inherentNature;
        private DelayTendency _delayTendency;

        [TestInitialize]
        public void Initialize_DispositionTest()
        {
            _inherentNature = InherentNature.Nonchalant;

            _delayTendency = DelayTendency.Thoughtless;
        }

        [TestMethod]
        public void Constructor_ShouldSetInherentNature()
        {
            //Arrange

            //Act
            var disposition = new Disposition(_inherentNature, _delayTendency);

            //Assert
            Assert.AreEqual(_inherentNature, disposition.InherentNature);
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendancy()
        {
            //Arrange

            //Act
            var disposition = new Disposition(_inherentNature, _delayTendency);

            //Assert
            Assert.AreEqual(_delayTendency, disposition.DelayTendency);
        }
    }
}
