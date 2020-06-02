namespace GameEngine
{
    public class Paper : IHand
    {
        public Outcome Play(IHand opponent)
        {
            return opponent.GetOutcome(this);
        }
        public Outcome GetOutcome(Rock rock)
        {
            return Outcome.LOSE;
        }

        public Outcome GetOutcome(Paper paper)
        {
            return Outcome.TIE;
        }

        public Outcome GetOutcome(Scissor scissor)
        {
            return Outcome.WIN;
        }

        public override string ToString()
        {
            return "Paper";
        }
    }
}