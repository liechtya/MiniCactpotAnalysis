using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class PartialXStrategy : RevealStrategy
    {
        public PartialXStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 2, 4, 6 },
                new int[] { 0, 2, 4, 8 },
                new int[] { 2, 4, 6, 8 },
                new int[] { 0, 4, 6, 8 },
            };
            this.incompatiableStartingPositions = new List<int>() { 1, 3, 5, 7 };
            this.name = "Partial X";
        }
    }

}
