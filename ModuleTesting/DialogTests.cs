using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;

namespace ModuleTesting
{
    [TestClass]
    public class DialogTests
    {
        //Notice! What we're doin' is tightly coupling GetLines() with the Lines property through the Dialogue obj's Constructor.
        public class TestDialogue : Dialogue
        {
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
        public void GetLines_ShouldReturnAnOccupiedCollection()
        {
            //Arrange
            var dialog = new TestDialogue();

            //Act
            var result = dialog.GetLines();

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void Constructor_ShouldSetLines_WithGetLines()
        {
            //Arrange
            var dialog = new TestDialogue();

            //Act
            var result = dialog.GetLines();

            //Assert
            Assert.IsTrue(dialog.Lines.All(result.Contains));
        }
    }
}
