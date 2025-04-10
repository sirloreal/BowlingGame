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

        public int Score()
        {
            int total = 0;
            foreach (Frame frame in _frames)
            {
                total += frame.Score();
            }
            return total;
        }
    }
}
