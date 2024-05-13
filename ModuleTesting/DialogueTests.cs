using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RoyalDomain.Interfaces;
using RoyalDomain.Objects;

namespace ModuleTesting
{
    [TestClass]
    public class DialogueTests
    {
        //Notice! What we're doin' is tightly coupling GetLines() with the Lines property through the Dialogue obj's Constructor.
        
        private Mock<IProfile> _profile;

        [TestInitialize]
        public void Initialize_DialogueTests()
        {
            _profile = new Mock<IProfile>();

        }

        public class TestDialogue : Dialogue
        {
            public TestDialogue(IProfile profile) : base(profile)
            {

            }

            public override List<string> GetLines()
            {
                return new List<string>()
                {
                "Ya'know, I really like trains",
                "A train on time is worth grapes on the vine"
                };
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetProfile()
        {
            //Arrange
            var dialog = new TestDialogue(_profile.Object);

            //Act

            //Assert
            Assert.AreEqual(_profile.Object, dialog.Profile);
        }

        [TestMethod]
        public void GetLines_ShouldReturnAnOccupiedCollection()
        {
            //Arrange
            var dialog = new TestDialogue(_profile.Object);

            //Act
            var result = dialog.GetLines();

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void Constructor_ShouldSetLines_WithGetLines()
        {
            //Arrange
            var dialog = new TestDialogue(_profile.Object);

            //Act
            var result = dialog.GetLines();

            //Assert
            Assert.IsTrue(dialog.Lines.All(result.Contains));
        }
    }
}
