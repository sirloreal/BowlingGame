namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        [Fact]
        public void GutterBalls() // Whole game of gutterballs
        {
            var game = new BowlingGame.BowlingGame();
            for (int i = 0; i < 10; i++)
            {
                game.RollFrame(0,0);
            }
            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void AllThrees() // Whole game of threes
        {
            var game = new BowlingGame.BowlingGame();
            for (int i = 0; i < 10; i++)
            {
                game.RollFrame(3, 3);
            }
            Assert.Equal(60, game.Score());
        }
    }
}