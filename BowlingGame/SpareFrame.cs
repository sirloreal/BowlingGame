using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private ArrayList throws;
        private int startingThrow;

        public SpareFrame(ArrayList throws, int startingThrow, int firstRoll, int secondRoll)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(firstRoll);
            throws.Add(secondRoll);
        }

        private int NextRoll()
        {
            return (int)throws[startingThrow + 2];
        }

        public int Score()
        {
            return 10 + NextRoll();
        }
    }
}
