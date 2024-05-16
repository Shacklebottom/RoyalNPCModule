using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;
using RoyalDomain.Interfaces;

namespace ModuleTesting
{
    [TestClass]
    public class DialogueManagerTests
    {
        private DialogueManager _dialogueManager;

        [TestMethod]
        public void GetFileInfo_ReturnsAnOccupiedCollection()
        {
            //Arrange
            var filePath = "C:\\ProjectTracking\\Resources\\Royal NPCs\\Documents\\testFile.txt";

            _dialogueManager = new DialogueManager();

            //Act
            var result = _dialogueManager.GetFileInfo(filePath);

            //Assert
            Assert.IsTrue(result.Count > 0, 
                "collection returned with no elements");
        }
    }
}
