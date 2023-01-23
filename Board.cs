
namespace MiniCactpotAnalysis
{
    public class Board
    {
        
        private Square[] TheBoard;
        private bool OpenBoard;

        public Board()
        {
            TheBoard = new Square[9];
            for(int i = 0; i < TheBoard.Length; i++)
            {
                TheBoard[i] = new Square();
            }
            OpenBoard = true;
        }

        public Board(int position, int revealedNum)
        {
            TheBoard = new Square[9];
            for(int i = 0; i < TheBoard.Length; i++)
            {
                if(i == position)
                {
                    TheBoard[i] = new Square(revealedNum);
                } else
                {
                    TheBoard[i] = new Square();
                }
            }
            OpenBoard = true;
        }

        public int GetSquare(int SquarePosition)
        {
            return TheBoard[SquarePosition].GetValue();
        }

        public void SetSquare(int SquarePosition, int SettingNum)
        {
            if (SquarePosition >= 0 && SquarePosition < TheBoard.Length)
            {
                if (SettingNum >= 0 && SettingNum <= 9)
                {
                    TheBoard[SquarePosition].SetValue(SettingNum);
                    if(SettingNum != 0){
                        OpenBoard = false;
                    }
                }
            }
        }

        public int[] GetAllSquareValues()
        {
            int[] values = new int[TheBoard.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = TheBoard[i].GetValue();
            }
            return values;
        }

        public bool GetOpenBoard(){
            return this.OpenBoard;
        }
        
        public int GetLineSum(int[] SelectedLine)
        {
            int sum = 0;
            foreach (int item in SelectedLine)
            {
                sum += TheBoard[item].GetValue();
            }
            return sum;
        }

        public void Reset()
        {
            foreach (Square item in TheBoard)
            {
                item.SetValue(0);
            }
            OpenBoard = true;
        }

        public void ToString()
        {
            Console.WriteLine("{0} {1} {2}", TheBoard[0].GetValue(), TheBoard[1].GetValue(), TheBoard[2].GetValue());
            Console.WriteLine("{0} {1} {2}", TheBoard[3].GetValue(), TheBoard[4].GetValue(), TheBoard[5].GetValue());
            Console.WriteLine("{0} {1} {2}", TheBoard[6].GetValue(), TheBoard[7].GetValue(), TheBoard[8].GetValue());
        }

    }
}

