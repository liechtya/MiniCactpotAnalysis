
namespace MiniCactpotAnalysis
{
    public class Board
    {
        
        private Square[] theBoard;
        private bool openBoard;

        public Board()
        {
            theBoard = new Square[9];
            for(int i = 0; i < theBoard.Length; i++)
            {
                theBoard[i] = new Square();
            }
            openBoard = true;
        }

        public Board(int position, int revealedNum)
        {
            theBoard = new Square[9];
            for(int i = 0; i < theBoard.Length; i++)
            {
                if(i == position)
                {
                    theBoard[i] = new Square(revealedNum);
                } else
                {
                    theBoard[i] = new Square();
                }
            }
            openBoard = true;
        }

        public int GetSquare(int squarePosition)
        {
            return theBoard[squarePosition].GetValue();
        }

        public void SetSquare(int squarePosition, int settingNum)
        {
            if (squarePosition >= 0 && squarePosition < theBoard.Length)
            {
                if (settingNum >= 0 && settingNum <= 9)
                {
                    theBoard[squarePosition].SetValue(settingNum);
                    if(settingNum != 0){
                        openBoard = false;
                    }
                }
            }
        }

        public int[] GetAllSquareValues()
        {
            int[] values = new int[theBoard.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = theBoard[i].GetValue();
            }
            return values;
        }

        public bool GetOpenBoard(){
            return this.openBoard;
        }
        
        public int GetLineSum(int[] selectedLine)
        {
            int sum = 0;
            foreach (int item in selectedLine)
            {
                sum += theBoard[item].GetValue();
            }
            return sum;
        }

        public void Reset()
        {
            foreach (Square item in theBoard)
            {
                item.SetValue(0);
            }
            openBoard = true;
        }

        public void ToString()
        {
            Console.WriteLine("{0} {1} {2}", theBoard[0].GetValue(), theBoard[1].GetValue(), theBoard[2].GetValue());
            Console.WriteLine("{0} {1} {2}", theBoard[3].GetValue(), theBoard[4].GetValue(), theBoard[5].GetValue());
            Console.WriteLine("{0} {1} {2}", theBoard[6].GetValue(), theBoard[7].GetValue(), theBoard[8].GetValue());
        }

    }
}

