using System.Collections;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly ArrayList _frames;
        public BowlingGame()
        {
            _frames = new ArrayList();
        }

        public void RollFrame(int firstRoll, int secondRoll)
        {
            _frames.Add(new Frame(firstRoll, secondRoll));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            _frames.Add(new SpareFrame(firstThrow, secondThrow));
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
