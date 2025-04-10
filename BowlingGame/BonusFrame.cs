using System.Collections;

namespace BowlingGame
{
    internal class BonusFrame : Frame
    {

        public BonusFrame(ArrayList throws, int firstThrow)
            :base(throws)
        {
            throws.Add(firstThrow);
        }

        public override int Score()
        {
            return 0;
        }
    }
}