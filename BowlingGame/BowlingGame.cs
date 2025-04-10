using System.Collections;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly List<int> _throws;
        private readonly List<IFrame> _frames;
        public BowlingGame()
        {
            _throws = new List<int>();
            _frames = new List<IFrame>();
        }

        public void RollFrame(int firstRoll, int secondRoll)
        {
            _frames.Add(new OpenFrame(_throws, firstRoll, secondRoll));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            _frames.Add(new SpareFrame(_throws, firstThrow, secondThrow));
        }

        public void Strike()
        {
            _frames.Add(new StrikeFrame(_throws));
        }

        public void BonusRoll(int firstThrow)
        {
            _frames.Add(new BonusFrame(_throws, firstThrow));
        }

        public int Score()
        {
            int total = 0;
            foreach (IFrame frame in _frames)
            {
                total += frame.Score();
            }
            return total;
        }
    }
}
