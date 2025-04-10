using System.Collections;

namespace BowlingGame
{
    internal abstract class Frame : IFrame
    {
        protected List<int> throws;
        protected int startingThrow;

        public Frame(List<int> throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }
        abstract public int Score();

    }
}
