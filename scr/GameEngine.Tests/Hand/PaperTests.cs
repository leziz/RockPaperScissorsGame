using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class PaperTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullReferenceExceptionExpectedIfNoMoveIsPassed()
        {
            new Paper().Play(null);
        }

        [TestMethod]
        public void PaperBeatsRock()
        {
            Assert.AreEqual(new Paper().Play(new Rock()), Outcome.WIN);
        }
        [TestMethod]
        public void PaperDrawsPaper()
        {
            Assert.AreEqual(new Paper().Play(new Paper()), Outcome.TIE);
        }
        [TestMethod]
        public void PaperLosesScissor()
        {
            Assert.AreEqual(new Paper().Play(new Scissor()), Outcome.LOSE);
        }
    }
}