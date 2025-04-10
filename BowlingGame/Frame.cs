namespace BowlingGame
{
    internal class Frame : IFrame
    {
        private int firstRoll;
        private int secondRoll;

        public Frame(int firstRoll, int secondRoll)
        {
            this.firstRoll = firstRoll;
            this.secondRoll = secondRoll;
        }

        public int Score()
        {
            return firstRoll + secondRoll;
        }
    }
}