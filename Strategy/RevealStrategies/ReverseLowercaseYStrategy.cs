using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class ReverseLowercaseYStrategy : RevealStrategy
    {
        public ReverseLowercaseYStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 1, 4, 8 },
                new int[] { 2, 4, 5, 6 },
                new int[] { 0, 4, 7, 8 },
                new int[] { 2, 3, 4, 6 },
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Reverse Lowercase Y";
        }
    }

}
