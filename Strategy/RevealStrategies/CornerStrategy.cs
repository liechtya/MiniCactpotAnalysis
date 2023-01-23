using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class CornerStrategy : RevealStrategy
    {
        public CornerStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 2, 6, 8 },
            };
            this.incompatiableStartingPositions = new List<int>() { 1, 3, 4, 5, 7 };
            this.name = "Corner";
        }
    }

}