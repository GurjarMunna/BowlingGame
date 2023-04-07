using Bowling_Game;

namespace Bowling_GameTests
{
    public class BowlingGameTest
    {
        private BowlingGame g;

        public BowlingGameTest()
        {
            g = new BowlingGame();
        }
        private void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }
        private void rollSpare()
        {
            g.Roll(6);
            g.Roll(4);
        }
        /*E.g, if a bowler rolls, 4,4 
         Their score is 8 */
        [Fact]
        public void CanRollGame()
        {
            g.Roll(4);
            g.Roll(4);
            Assert.Equal(8, g.Score());
        }
        [Fact]
        public void CanRollGutterGame()
        {
            rollMany(20, 0);
            Assert.Equal(0, g.Score());
        }
        [Fact]
        public void CanRollAllOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, g.Score());
        }
        /*E.g, if a bowler rolls, 4,6 |  5, 0
        Their score is 20. So that's (4 + 6 + 5) + (5 + 0) */
        [Fact]
        public void CanRollOneSpare()
        {
            rollSpare();
            g.Roll(5);
            rollMany(17, 0);
            Assert.Equal(20, g.Score());
        }
        /*E.g, if a bowler rolls, 10 | 5, 4
        Their score is 28. So that's (10 + 5 + 4) + ( 5 + 4) */
        [Fact]
        public void CanRollOneStrike()
        {
            g.Roll(10);
            g.Roll(5);
            g.Roll(4);
            rollMany(16, 0);
            Assert.Equal(28, g.Score());
        }
        [Fact]
        public void CanRollPerfectGame()
        {
            rollMany(12, 10);
            Assert.Equal(300, g.Score());
        }

    }
}