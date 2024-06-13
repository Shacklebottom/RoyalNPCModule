using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RoyalDomain.Interfaces;
using RoyalDomain.Objects;

#pragma warning disable CS8618

namespace ModuleTesting
{
    [TestClass]
    public class DialogueTests
    {
        //Notice! What we're doin' is tightly coupling GetLines() with the Lines property through its custom getter.
        
        private Mock<IProfile> _profile;

        private Dialogue _dialog;

        [TestInitialize]
        public void Initialize_DialogueTests()
        {
            _profile = new Mock<IProfile>();

            _dialog = new TestDialogue(_profile.Object);
        }

        public class TestDialogue(IProfile profile) : Dialogue(profile)
        {
            public override List<string> GetLines()
            {
                return
                [
                "Ya'know, I really like trains",
                "A train on time is worth grapes on the vine"
                ];
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(_profile.Object, _dialog.Profile, 
                "the constructor is not setting the Profile field");
        }

        [TestMethod]
        public void GetLines_ShouldReturnAnOccupiedCollection()
        {
            //Arrange

            //Act
            var result = _dialog.GetLines();

            //Assert
            Assert.IsTrue(result.Count > 0, 
                "GetLines() did not return any elements");
        }

        [TestMethod]
        public void Lines_ShouldBeSet_WithGetLines()
        {
            //Arrange

            //Act
            var result = _dialog.GetLines();

            //Assert
            Assert.IsTrue(_dialog.Lines.All(result.Contains), 
                "the Lines field is not being set by GetLines()");
        }
    }
}
