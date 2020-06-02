namespace GameEngine
{
    public interface IPlayer
    {
        string Name { get; }
        IHand Move { get; }

        void SetMove(int id);
        Outcome Play(IHand opponent);
    }
}