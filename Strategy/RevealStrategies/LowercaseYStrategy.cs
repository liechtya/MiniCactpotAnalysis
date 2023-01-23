using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class LowercaseYStrategy : RevealStrategy
    {
        public LowercaseYStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 1, 2, 4, 6 },
                new int[] { 0, 4, 5, 8 },
                new int[] { 2, 4, 6, 7 },
                new int[] { 0, 3, 4, 8 },
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Lowercase Y";
        }
    }

}
