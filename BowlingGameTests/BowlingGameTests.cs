namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        private readonly BowlingGame.BowlingGame _game;

        public BowlingGameTests()
        {
            _game = new BowlingGame.BowlingGame();
        }

        [Fact]
        public void GutterBalls() // Whole game of gutterballs
        {
            ManyOpenFrames(10, 0, 0);
            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void AllThrees() // Whole game of threes
        {
            ManyOpenFrames(10, 3, 3);
            Assert.Equal(60, _game.Score());
        }

        [Fact]
        public void Spare()
        {
            _game.Spare(4, 6); // Spare
            _game.RollFrame(3, 5); // Next frame
            ManyOpenFrames(8, 0, 0); // Then 8 more frames
            Assert.Equal(21, _game.Score());
        }

        [Fact]
        public void Spare2()
        {
            _game.Spare(4, 6); // Spare
            _game.RollFrame(5, 3); // Next frame
            ManyOpenFrames(8, 0, 0); // Then 8 more frames
            Assert.Equal(23, _game.Score());
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
                _game.RollFrame(firstThrow, secondThrow);
        }
    }
}