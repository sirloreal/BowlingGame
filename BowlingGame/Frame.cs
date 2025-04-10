using System.Collections;

namespace BowlingGame
{
    internal class Frame : IFrame
    {
        private ArrayList throws;
        private int startingThrow;

        public Frame(ArrayList throws, int startingThrow, int firstRoll, int secondRoll)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(firstRoll);
            throws.Add(secondRoll);
        }

        public int Score()
        {
            return (int)throws[startingThrow] + (int)throws[startingThrow+1];
        }
    }
}