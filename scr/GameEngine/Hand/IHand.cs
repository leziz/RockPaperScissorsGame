namespace GameEngine
{
    public interface IHand
    {
        Outcome Play(IHand opponent);
        Outcome GetOutcome(Rock rock);
        Outcome GetOutcome(Paper paper);
        Outcome GetOutcome(Scissor scissor);
    }
}
