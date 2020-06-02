namespace GameEngine
{
    public class Rock : IHand
    {
        public Outcome Play(IHand opponent)
        {
            return opponent.GetOutcome(this);
        }
        public Outcome GetOutcome(Rock rock)
        {
            return Outcome.TIE;
        }

        public Outcome GetOutcome(Paper paper)
        {
            return Outcome.WIN;
        }

        public Outcome GetOutcome(Scissor scissor)
        {
            return Outcome.LOSE;
        }

        public override string ToString()
        {
            return "Rock";
        }
    }
}