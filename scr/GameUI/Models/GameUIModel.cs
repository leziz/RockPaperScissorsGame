using System;

namespace GameUI.Models
{
    public enum MoveChoice { ROCK, PAPER, SCISSORS, RANDOM }

    [Serializable]
    //View model that contains user selection and game result.
    public class GameUIModel
    {
        public MoveChoice Player1Move { get; set; }
        public MoveChoice Player2Move { get; set; }
        public string GameResult { get; set; }
    }
}