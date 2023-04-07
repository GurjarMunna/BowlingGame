namespace Bowling_Game
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        int currentRoll = 0;
        public int Score()
        {
            int score = 0;
            int rollIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isSpare(rollIndex))
                {
                    score += GetSpareScore(rollIndex);
                    rollIndex += 2;
                }
                else if (isStrike(rollIndex))
                {
                    score += GetStrikeScore(rollIndex);
                    rollIndex++;
                }
                else
                {
                    score += GetStandardScore(rollIndex);
                    rollIndex += 2;
                }

            }

            return score;
        }
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }
        private bool isSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }
        private bool isStrike(int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }
        public int GetStandardScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];

        }
        public int GetSpareScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];

        }
        public int GetStrikeScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
           
        }
        

    }
}