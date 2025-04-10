using System.Collections;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly ArrayList _rolls;
        public BowlingGame()
        {
            _rolls = new ArrayList();
        }

        public void RollFrame(int firstRoll, int secondRoll)
        {
            _rolls.Add(firstRoll);
            _rolls.Add(secondRoll);
        }

        public int Score()
        {
            int total = 0;
            foreach (int score in _rolls)
            {
                total += score;
            }
            return total;
        }
    }
}
