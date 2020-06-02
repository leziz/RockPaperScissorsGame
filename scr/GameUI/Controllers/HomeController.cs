using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameUI.Models;
using GameEngine;

namespace GameUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Default selection is Computer vs Computer
            GameUIModel gameModel = new GameUIModel
            {
                Player1Move = MoveChoice.RANDOM,//This will prevent invalid null move submission
                Player2Move = MoveChoice.RANDOM,//This will prevent invalid null move submission
                GameResult = string.Empty
            };
            return View(gameModel);
        }

        [HttpPost]
        /// This method is called when the Play button has been pressed
        /// The game ui model is bound to the form so arrives with data from the UI
        /// This method runs GameEngine to display the winner
        public IActionResult Index(GameUIModel gameUIModel)
        {
            Game game = new Game(new Player("Player1"), new Player("Player2"));
            gameUIModel.GameResult = game.Play((int)gameUIModel.Player1Move, (int)gameUIModel.Player2Move);
            return View(gameUIModel);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}