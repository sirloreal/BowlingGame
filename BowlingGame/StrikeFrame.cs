using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    internal class StrikeFrame : Frame
    {
        public StrikeFrame(ArrayList throws)
            :base(throws)
        {
            throws.Add(10);
        }

        private int FirstFollowingBall()
        {
            return (int)throws[startingThrow + 1];
        }

        private int SecondFollowingBall()
        {
            return (int)throws[startingThrow + 2];
        }
        public override int Score()
        {
            return 10 + FirstFollowingBall() + SecondFollowingBall();
        }
    }
}
