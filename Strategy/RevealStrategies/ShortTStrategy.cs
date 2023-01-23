using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class ShortTStrategy : RevealStrategy
    {
        public ShortTStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 1, 2, 4 },
                new int[] { 0, 3, 4, 6 },
                new int[] { 2, 4, 5, 8 },
                new int[] { 4, 6, 7, 8 },
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Short T";
        }
    }
}