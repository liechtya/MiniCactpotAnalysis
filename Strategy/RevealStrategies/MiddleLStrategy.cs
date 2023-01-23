using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class MiddleLStrategy : RevealStrategy
    {
        public MiddleLStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 1, 4, 7, 8 },
                new int[] { 2, 3, 4, 5 },
                new int[] { 0, 1, 4, 7 },
                new int[] { 3, 4, 5, 6 }
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Middle L";
        }
    }
}
