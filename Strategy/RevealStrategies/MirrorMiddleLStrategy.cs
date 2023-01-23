using System.Collections.Generic;

namespace MiniCactpotAnalysis
{
    public class MirrorMiddleLStrategy : RevealStrategy
    {
        public MirrorMiddleLStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 1, 4, 6, 7 },
                new int[] { 3, 4, 5, 8 },
                new int[] { 1, 2, 4, 7 },
                new int[] { 0, 3, 4, 5 }
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Mirror Middle L";
        }
    }
}
