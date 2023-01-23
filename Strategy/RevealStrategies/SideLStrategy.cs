

namespace MiniCactpotAnalysis
{
    public class SideLStrategy : RevealStrategy
    {
        public SideLStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 1, 2, 3 },
                new int[] { 1, 2, 5, 8 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 0, 3, 6, 7 }
            };
            this.incompatiableStartingPositions = new List<int>() { 4 };
            this.name = "Side L";
        }
    }
}
