using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    internal class SpareFrame : Frame
    {
        public SpareFrame(ArrayList throws, int firstRoll, int secondRoll)
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
