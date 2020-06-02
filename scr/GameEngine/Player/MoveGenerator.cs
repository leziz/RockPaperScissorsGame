using System;
namespace GameEngine
{
    public class MoveGenerator
    {
        public const short ROCK = 0,
                           PAPER = 1,
                           SCISSOR = 2,
                           RANDOM = 3;
        private static readonly Random random = new Random();
        public static IHand GetNext() => GetMove(random.Next(3));
        public static IHand GetMove(int id)
        {
            switch (id)
            {
                case ROCK:
                    return new Rock();
                case PAPER:
                    return new Paper();
                case SCISSOR:
                    return new Scissor();
                case RANDOM:
                    return GetNext();
                default:
                    throw new InvalidOperationException("Invalid Move Type");
            }
        }
    }
}