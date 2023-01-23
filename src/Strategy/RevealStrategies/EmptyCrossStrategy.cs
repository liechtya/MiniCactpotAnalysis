using System;
using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class EmptyCrossStrategy : RevealStrategy
    {
        public EmptyCrossStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 1, 3, 5, 7 }
            };
            this.incompatiableStartingPositions = new List<int>() { 0, 2, 4, 6, 8 };
            this.name = "Empty Cross";
        }
    }

}
