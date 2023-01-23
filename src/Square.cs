using System;

namespace MiniCactpotAnalysis
{
    class Square
    {
        private int value;

        public Square() { value = 0; }
        public Square(int num) { value = num; }

        public int GetValue() { return value; }
        public void SetValue(int num) { value = num; }
    }
}

