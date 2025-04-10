using System.Collections;

namespace BowlingGame
{
    internal abstract class Frame : IFrame
    {
        protected ArrayList throws;
        protected int startingThrow;

        public Frame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }
        abstract public int Score();

    }
}
