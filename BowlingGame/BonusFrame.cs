using System.Collections;

namespace BowlingGame
{
    internal class BonusFrame : Frame
    {

        public BonusFrame(List<int> throws, int firstThrow)
            :base(throws)
        {
            throws.Add(firstThrow);
        }

        public override int Score()
        {
            // With this implementation the bonus frame always follows a strike or a spare. 
            // Because the Strike and Spare classes are responsible for adding the extra throws, we don't need to do that here.
            return 0;
        }
    }
}