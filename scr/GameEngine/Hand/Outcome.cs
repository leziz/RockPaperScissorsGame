
namespace GameEngine
{
    public class Outcome
    {
        private readonly string description;

        public static readonly Outcome TIE = new Outcome("The game is a tie.");
        public static readonly Outcome WIN = new Outcome("Player 1 won!");
        public static readonly Outcome LOSE = new Outcome("Player 1 lost.");

        private Outcome(string description) => this.description = description;

        public override string ToString() => description;
    }
}