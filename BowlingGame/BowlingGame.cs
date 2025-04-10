using System.Collections;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly ArrayList _throws;
        private readonly ArrayList _frames;
        public BowlingGame()
        {
            _throws = new ArrayList();
            _frames = new ArrayList();
        }

        public void RollFrame(int firstRoll, int secondRoll)
        {
            _frames.Add(new Frame(_throws, _throws.Count, firstRoll, secondRoll));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            _frames.Add(new SpareFrame(_throws, _throws.Count, firstThrow, secondThrow));
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
