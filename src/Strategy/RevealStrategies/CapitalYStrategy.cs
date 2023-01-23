
namespace MiniCactpotAnalysis
{
    public class CapitalYStrategy: RevealStrategy
    {
        public CapitalYStrategy()
        {
            this.formations = new List<int[]>
            {
                new int[] { 0, 2, 4, 7 },
                new int[] { 1, 4, 6, 8 },
                new int[] { 2, 3, 4, 8 },
                new int[] { 0, 4, 5, 6 }
            };
            this.incompatiableStartingPositions = new List<int>();
            this.name = "Capital Y";
        }
    }
}

