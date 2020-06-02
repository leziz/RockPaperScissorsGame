using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class ScissorTests
    {
        [TestMethod]
        public void ScissorsLosesRock()
        {
            Assert.AreEqual(new Scissor().Play(new Rock()), Outcome.LOSE);
        }
        [TestMethod]
        public void ScissorsBeatsPaper()
        {
            Assert.AreEqual(new Scissor().Play(new Paper()), Outcome.WIN);
        }
        [TestMethod]
        public void ScissorsDrawsScissor()
        {
            Assert.AreEqual(new Scissor().Play(new Scissor()), Outcome.TIE);
        }
    }
}