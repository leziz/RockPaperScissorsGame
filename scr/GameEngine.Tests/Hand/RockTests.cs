using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class RockTests
    {
        [TestMethod]
        public void RockDrawsRock()
        {
            Assert.AreEqual(new Rock().Play(new Rock()), Outcome.TIE);
        }
        [TestMethod]
        public void RockLosesPaper()
        {
            Assert.AreEqual(new Rock().Play(new Paper()), Outcome.LOSE);
        }
        [TestMethod]
        public void RockBeatsScissor()
        {
            Assert.AreEqual(new Rock().Play(new Scissor()), Outcome.WIN);
        }
    }
}