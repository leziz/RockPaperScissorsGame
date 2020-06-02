namespace GameEngine
{
    public class Player : IPlayer
    {
        public Player(string name) => Name = name;
        public string Name { get; }
        private IHand move;
        public IHand Move { get { return move; } }
        public void SetMove(int moveId) => move = MoveGenerator.GetMove(moveId);
        public Outcome Play(IHand opponentMove) => Move.Play(opponentMove);
    }
}