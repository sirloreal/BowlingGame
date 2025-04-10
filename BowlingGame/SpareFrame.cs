using System.Collections;

namespace BowlingGame
{
    internal class SpareFrame : Frame
    {
        public SpareFrame(List<int> throws, int firstRoll, int secondRoll)
            :base(throws)
        {
            throws.Add(firstRoll);
            throws.Add(secondRoll);
        }

        private int NextBall()
        {
            return (int)throws[startingThrow + 2];
        }

        public override int Score()
        {
            return 10 + NextBall();
        }
    }
}
