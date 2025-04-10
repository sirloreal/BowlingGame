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

        [Fact]
        public void Strike()
        {
            _game.Strike();
            _game.RollFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.Equal(26, _game.Score());
        }

        [Fact]
        public void StrikeFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            _game.Strike();
            _game.BonusRoll(5);
            _game.BonusRoll(3);
            Assert.Equal(18, _game.Score());
        }

        [Fact]
        public void SpareFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            _game.Spare(4, 6);
            _game.BonusRoll(5);
            Assert.Equal(15, _game.Score());
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
                _game.RollFrame(firstThrow, secondThrow);
        }
    }
}