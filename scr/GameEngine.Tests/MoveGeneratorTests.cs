using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GameEngine.Tests
{
    [TestClass]
    public class MoveGeneratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidMoveException()
        {
            MoveGenerator.GetMove(5);
        }

        [TestMethod]
        // Expect a even distribution of moves from a computer player
        public void CheckRandomMoveGeneratorCreatesExpectedMoves()
        {

            Dictionary<string, int> typeCount = new Dictionary<string, int>();

            int gameCount = 1000;
            for (int gameNumber = 0; gameNumber < gameCount; gameNumber++)
            {
                IHand nextRandomMove = MoveGenerator.GetNext();
                string key = nextRandomMove.ToString();
                if (typeCount.ContainsKey(key))
                {
                    typeCount[key]++;
                }
                else
                {
                    typeCount.Add(key, 1);
                }
            }

            Assert.IsTrue(typeCount.Count == 3, "Random move generator should produce all three move types - Rock, Paper, Scissor");

            // Random should produce equal distribution of three moves, to avoid variance failures takeing half of the expecte value.
            int fairExpectedCount = gameCount / 6;
            foreach (string key in typeCount.Keys)
            {
                Assert.IsTrue(typeCount[key] > fairExpectedCount, $"Random move generator has not created expected {key} moves");
            }
        }
    }
}