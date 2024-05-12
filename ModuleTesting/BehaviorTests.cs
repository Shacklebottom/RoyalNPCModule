using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoyalDomain;

namespace ModuleTesting
{
    [TestClass]
    public class BehaviorTests
    {
        [TestMethod]
        public void Constructor_ShouldSetSociabilityWeights()
        {
            //Arrange
            var behavior = new Behavior();

            //Act
            

            //Assert
            //1. that each item in Sociability is in the dictionary, and
            foreach (Sociability item in Enum.GetValues(typeof(Sociability)))
            {
                Assert.IsTrue(behavior.sociabilityWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in behavior.sociabilityWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }

        [TestMethod]
        public void Constructor_ShouldSetDelayTendencyWeights()
        {
            //Arrange
            var behavior = new Behavior();
            
            //Act


            //Assert
            //1. that each item in DelayTendency is in the dictionary, and
            foreach (DelayTendency item in Enum.GetValues(typeof(DelayTendency)))
            {
                Assert.IsTrue(behavior.delaytendencyWeights.ContainsKey(item));
            }
            //2. that each item has a value associated with it.
            foreach (var item in behavior.delaytendencyWeights)
            {
                Assert.IsTrue(item.Value > 0);
            }
        }
    }
}
