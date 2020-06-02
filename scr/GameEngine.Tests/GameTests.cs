using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class GameTests
    {
        IPlayer player1, player2;
        IGame game;

        [TestInitialize]
        public void Setup()
        {
            player1 = new Player("Player1");
            player2 = new Player("Player2");
            game = new Game(player1, player2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidMoveException()
        {
            int InvalidMoveId = 5;
            game.Play(InvalidMoveId, MoveGenerator.PAPER);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GameShouldHaveTwoPlayers()
        {
            new Game(null, null).Play(MoveGenerator.PAPER, MoveGenerator.PAPER);
        }

        [TestMethod]
        public void PaperMoveTiesPaperMove()
        {
            string gameOutcome = game.Play(MoveGenerator.PAPER, MoveGenerator.PAPER);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void PaperMoveBeatsRockMove()
        {
            string gameOutcome = game.Play(MoveGenerator.PAPER, MoveGenerator.ROCK);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void PaperMoveLosesToScissorsMove()
        {
            string gameOutcome = game.Play(MoveGenerator.PAPER, MoveGenerator.SCISSOR);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }


        [TestMethod]
        public void RockMoveLosesToPaperMove()
        {
            string gameOutcome = game.Play(MoveGenerator.ROCK, MoveGenerator.PAPER);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void RockMoveTiesWithRockMove()
        {
            string gameOutcome = game.Play(MoveGenerator.ROCK, MoveGenerator.ROCK);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void RockMoveBeatsScissorsMove()
        {
            string gameOutcome = game.Play(MoveGenerator.ROCK, MoveGenerator.SCISSOR);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }


        [TestMethod]
        public void ScissorsMoveBeatsPaperMove()
        {
            string gameOutcome = game.Play(MoveGenerator.SCISSOR, MoveGenerator.PAPER);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void ScissorsMoveLosesToRockMove()
        {
            string gameOutcome = game.Play(MoveGenerator.SCISSOR, MoveGenerator.ROCK);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }

        [TestMethod]
        public void ScissorsMoveTiesWithScissorsMove()
        {
            string gameOutcome = game.Play(MoveGenerator.SCISSOR, MoveGenerator.SCISSOR);
            Outcome playersMoveOutcome = player1.Play(player2.Move);
            string expectedGameOutcome = $"({player1.Move}/{player2.Move}): {playersMoveOutcome}";
            Assert.AreEqual(gameOutcome, expectedGameOutcome);
        }
    }
}