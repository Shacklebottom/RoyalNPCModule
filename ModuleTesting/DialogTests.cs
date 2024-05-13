using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTesting
{
    [TestClass]
    public class DialogTests
    {
        [TestMethod]
        public void Constructor_ShouldSetLines()
        {
            //Arrange
            var lines = new List<string>()
            {
                "Ya'know, I really like trains",
                "A train on time is worth grapes on the vine"
            };

            //Act
            var dialog = new Dialogue(lines);

            //Assert
            Assert.AreEqual(lines, dialog.Lines);
        }
    }
}
