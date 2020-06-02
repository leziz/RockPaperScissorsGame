using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameUI.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Moq;
using GameUI.Models;

namespace GameUI.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        ILogger<HomeController> logger = Mock.Of<ILogger<HomeController>>();

        [TestMethod]
        public void IndexGetRender()
        {
            HomeController controller = new HomeController(logger);
            ViewResult result = controller.Index() as ViewResult;
            var uiModel = (GameUIModel)result.Model;
            Assert.AreEqual(uiModel.Player1Move, MoveChoice.RANDOM);
            Assert.AreEqual(uiModel.Player1Move, MoveChoice.RANDOM);
            Assert.AreEqual(uiModel.GameResult, string.Empty);
        }

        [TestMethod]
        public void IndexPostRender_PaperTiesPaper()
        {
            HomeController controller = new HomeController(logger);
            var userInput = new GameUIModel()
            {
                Player1Move = MoveChoice.PAPER,
                Player2Move = MoveChoice.PAPER
            };
            ViewResult result = controller.Index(userInput) as ViewResult;
            var uiModel = (GameUIModel)result.Model;
            Assert.AreEqual(uiModel.GameResult, "(Paper/Paper): The game is a tie.");
        }

        [TestMethod]
        public void IndexPostRender_PaperBeatsRock()
        {
            HomeController controller = new HomeController(logger);
            var userInput = new GameUIModel()
            {
                Player1Move = MoveChoice.PAPER,
                Player2Move = MoveChoice.ROCK
            };
            ViewResult result = controller.Index(userInput) as ViewResult;
            var uiModel = (GameUIModel)result.Model;
            Assert.AreEqual(uiModel.GameResult, "(Paper/Rock): Player 1 won!");
        }

        [TestMethod]
        public void IndexPostRender_PaperLosesToScissors()
        {
            HomeController controller = new HomeController(logger);
            var userInput = new GameUIModel()
            {
                Player1Move = MoveChoice.PAPER,
                Player2Move = MoveChoice.SCISSORS
            };
            ViewResult result = controller.Index(userInput) as ViewResult;
            var uiModel = (GameUIModel)result.Model;
            Assert.AreEqual(uiModel.GameResult, "(Paper/Scissor): Player 1 lost.");
        }
    }
}
