namespace GameEngine
{
    public class Scissor : IHand
    {
        public Outcome Play(IHand opponent)
        {
            return opponent.GetOutcome(this);
        }

        public Outcome GetOutcome(Paper paper)
        {
            return Outcome.LOSE;
        }

        public Outcome GetOutcome(Rock rock)
        {
            return Outcome.WIN;
        }

        public Outcome GetOutcome(Scissor scissor)
        {
            return Outcome.TIE;
        }

        public override string ToString()
        {
            return "Scissor";
        }
    }
}
