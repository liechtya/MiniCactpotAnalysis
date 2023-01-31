
namespace MiniCactpotAnalysis
{
    public class BoardPlayer
    {
        private Board cactpotBoard;
        private List<int> numsAval;
        private int startingPos;

        public BoardPlayer(Random rnd)
        {
            numsAval = (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToList();
            cactpotBoard = new Board();
            NormalStart(rnd);
        }

        public BoardPlayer(int position, int revealedNum)
        {
            numsAval = (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToList();
            cactpotBoard = new Board(position, revealedNum);
            startingPos = position;
        }

        public Board GetBoard()
        {
            return cactpotBoard;
        }

        public int GetStartingPos()
        { 
            return startingPos;
        }

        public int[] GetBoardValues()
        {
            return cactpotBoard.GetAllSquareValues();
        }

        public List<int> GetNumsAvaliable()
        {
            return numsAval;
        }

        public void CustomStart(int position, int revealValue){
            if (!cactpotBoard.GetOpenBoard())
            {
                this.Reset();
            }
            cactpotBoard.SetSquare(position, revealValue);
            numsAval.Remove(revealValue);
            startingPos = position;

        }

        public void NormalStart(Random rand)
        {
            if (!cactpotBoard.GetOpenBoard())
            {
                this.Reset();
            }
            int position = rand.Next(9);
            int revealValue = rand.Next(1, 10);
            cactpotBoard.SetSquare(position, revealValue);
            numsAval.Remove(revealValue);
            startingPos = position;
            
        }

        public void Proceed(int[] positions, Random rand)
        {
            if(cactpotBoard.GetOpenBoard())
            {
                NormalStart(rand);
            }

            if (positions.Length > 3)
            {
                positions = positions.Take(3).ToArray();
            }
            else if (positions.Length < 3)
            {
                int[] tempArray = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    if (i < positions.Length)
                    {
                        tempArray[i] = positions[i];
                    }
                    else
                    {
                        tempArray[i] = rand.Next(9);
                    }
                }
            }
            int pos = 0;
            int value = 0;
            foreach (int item in positions)
            {
                pos = item;
                while (cactpotBoard.GetSquare(pos) != 0)
                {
                    pos = rand.Next(9);
                }
                value = numsAval[rand.Next(0, numsAval.Count)];
                cactpotBoard.SetSquare(pos, value);
                numsAval.Remove(value);
            }
        }

        public void CompleteTheBoard(Random rand)
        {
            int value = 0;
            for (int squarePos = 0; squarePos < 9; squarePos++)
            {
                if (cactpotBoard.GetSquare(squarePos) == 0)
                {
                    value = numsAval[rand.Next(0, numsAval.Count)];
                    cactpotBoard.SetSquare(squarePos, value);
                    numsAval.Remove(value);
                }
            }
        }

        public void Payout(int[] selectedLine, Dictionary<int, int> payoutTable)
        {
            int sum = cactpotBoard.GetLineSum(selectedLine);
            cactpotBoard.ToString();
            int payout = payoutTable[sum];
            Console.WriteLine("Sum = {0}, Payout of {1}", sum, payout);
        }

        public void Reset(){
            numsAval = (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToList();
            cactpotBoard.Reset();
        }
    }
}

