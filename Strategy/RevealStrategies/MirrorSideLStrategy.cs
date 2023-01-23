using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class MirrorSideLStrategy : RevealStrategy
    {
        public MirrorSideLStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 1, 2, 5 },
                new int[] { 2, 5, 7 ,8 },
                new int[] { 3, 6, 7, 8 },
                new int[] { 0, 1, 3, 6 }
            };
            this.incompatiableStartingPositions = new List<int>() { 4 };
            this.name = "Mirror Side L";
        }
    }
}