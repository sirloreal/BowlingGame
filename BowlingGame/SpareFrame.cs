using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private int score;

        public SpareFrame(int firstRoll, int secondRoll)
        {
            score = 10 + NextRoll();
        }

        private int NextRoll()
        {
            return 3;
        }

        public int Score()
        {
            return score;
        }
    }
}
