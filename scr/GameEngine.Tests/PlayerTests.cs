using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class PlayerTests
    {
        IPlayer rockPlayer = new Player("RockPlayer");
        IPlayer paperPlayer = new Player("PaperPlayer");
        IPlayer scissorPlayer = new Player("ScissorPlayer");
        IHand rockOpponentMove = new Rock();
        IHand paperOpponentMove = new Paper();
        IHand scissorOpponentMove = new Scissor();

        [TestInitialize]
        public void Setup()
        {
            rockPlayer.SetMove(MoveGenerator.ROCK);
            paperPlayer.SetMove(MoveGenerator.PAPER);
            scissorPlayer.SetMove(MoveGenerator.SCISSOR);
        }

        [TestMethod]
        public void RockPlayerTiesWithRockOpponentMove()
        {
            Assert.AreEqual(rockPlayer.Play(rockOpponentMove), Outcome.TIE);
        }

        [TestMethod]
        public void RockPlayerLosesToPaperOpponentMove()
        {
            Assert.AreEqual(rockPlayer.Play(paperOpponentMove), Outcome.LOSE);
        }

        [TestMethod]
        public void RockPlayerBeatsScissorOpponentMove()
        {
            Assert.AreEqual(rockPlayer.Play(scissorOpponentMove), Outcome.WIN);
        }

        [TestMethod]
        public void PaperPlayerTiesWithPaperOpponentMove()
        {
            Assert.AreEqual(paperPlayer.Play(paperOpponentMove), Outcome.TIE);
        }

        [TestMethod]
        public void PaperPlayerLosesToScissorOpponentMove()
        {
            Assert.AreEqual(paperPlayer.Play(scissorOpponentMove), Outcome.LOSE);
        }

        [TestMethod]
        public void PaperPlayerBeatsRockOpponentMove()
        {
            Assert.AreEqual(paperPlayer.Play(rockOpponentMove), Outcome.WIN);
        }

        [TestMethod]
        public void ScissorPlayerTiesWithScissorOpponentMove()
        {
            Assert.AreEqual(scissorPlayer.Play(scissorOpponentMove), Outcome.TIE);
        }

        [TestMethod]
        public void ScissorPlayerLosesToRockOpponentMove()
        {
            Assert.AreEqual(scissorPlayer.Play(rockOpponentMove), Outcome.LOSE);
        }

        [TestMethod]
        public void ScissorPlayerBeatsPaperOpponentMove()
        {
            Assert.AreEqual(scissorPlayer.Play(paperOpponentMove), Outcome.WIN);
        }
    }
}
