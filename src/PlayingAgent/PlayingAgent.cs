
namespace MiniCactpotAnalysis {
    public abstract class PlayingAgent
    {
        protected BoardPlayer boardPlayer;
        protected RevealStrategy implementedRevealStrategy;
        protected List<RevealStrategy> possibleRevealStrategies;
        protected Random rand;
        protected string name;

        public PlayingAgent()
        {
            this.rand = new Random();
            this.boardPlayer = new BoardPlayer(rand);
        }

        public void SelectAStrategy()
        {
            List<RevealStrategy> avalStrategies = new List<RevealStrategy>();
            foreach (var possibleRevealStrategy in possibleRevealStrategies)
            {
                if (possibleRevealStrategy.IsValid(boardPlayer.GetStartingPos()))
                {
                    avalStrategies.Add(possibleRevealStrategy);
                }
            }
            int strategyToSelect = rand.Next(avalStrategies.Count);
            implementedRevealStrategy = avalStrategies[strategyToSelect];
        }

        public void RevealNumbers()
        {
            boardPlayer.Proceed(implementedRevealStrategy.UseStrategy(boardPlayer.GetStartingPos(), rand), rand);
        }

        public void SelectLineAndPayout(Dictionary<int, int> payTable)
        {
            List<int[]> Lines = new List<int[]>()
            {
                new [] { 0, 1, 2 },
                new [] { 3, 4, 5 },
                new [] { 6, 7, 8 },
                new [] { 0, 4, 8 },
                new [] { 1, 4, 7 },
                new [] { 2, 5, 8 },
                new [] { 0, 3, 6 },
                new [] { 2, 4, 6 }
            };
            int[] boardValues = boardPlayer.GetBoardValues();

            double projectedPayout = 0;
            double highestProjectedPayout = 0;
            List<List<int>> possibleValues = new List<List<int>>();
            int[] selectedLine = new int[3];
            foreach (var line in Lines)
            {
                for (int i = 0; i < 3; i++)
                {
                    int posValue = boardValues[line[i]];
                    
                    if (posValue == 0)
                    {
                        possibleValues.Add(boardPlayer.GetNumsAvaliable());
                    }
                    else
                    {
                        possibleValues.Add(new List<int>() { posValue });
                    }
                }

                int sum = 0;
                List<int> possibleFinalSums = new List<int>();
                foreach (int firstPosPossibleValue in possibleValues[0])
                {
                    foreach (int secondPosPossibleValue in possibleValues[1])
                    {
                        foreach (int thirdPosPossibleValue in possibleValues[2])
                        {
                            sum = firstPosPossibleValue + secondPosPossibleValue + thirdPosPossibleValue;
                            possibleFinalSums.Add(sum);
                        }
                    }
                }

                List<int> possiblePayouts = new List<int>();
                foreach (var item in possibleFinalSums)
                {
                    possiblePayouts.Add(payTable[item]);
                }
                projectedPayout = possiblePayouts.Sum() / possiblePayouts.Count();
                if (projectedPayout > highestProjectedPayout)
                {
                    highestProjectedPayout = projectedPayout;
                    selectedLine = line;
                }
            }

            boardPlayer.CompleteTheBoard(rand);
            boardPlayer.Payout(selectedLine, payTable);
        }
        
    }
}

