namespace GameEngine
{
    public class Game : IGame
    {
        IPlayer player1 = new Player("Player1");
        IPlayer player2 = new Player("Player");

        public Game(IPlayer p1, IPlayer p2)
        {
            player1 = p1;
            player2 = p2;
        }

        public string Play(int player1Move, int player2Move)
        {
            player1.SetMove(player1Move);
            player2.SetMove(player2Move);

            Outcome outcome = player1.Play(player2.Move);
            return ($"({player1.Move}/{player2.Move}): {outcome}");
        }
    }
}