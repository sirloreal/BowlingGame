using System.Collections;

namespace BowlingGame
{
    internal class OpenFrame : Frame
    {
        public OpenFrame(ArrayList throws, int firstRoll, int secondRoll)
            : base(throws)
        {
            throws.Add(firstRoll);
            throws.Add(secondRoll);
        }

        public override int Score()
        {
            return (int)throws[startingThrow] + (int)throws[startingThrow+1];
        }
    }
}