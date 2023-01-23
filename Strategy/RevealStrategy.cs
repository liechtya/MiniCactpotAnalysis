
namespace MiniCactpotAnalysis
{
    public abstract class RevealStrategy
    {
        protected List<int[]> formations;
        public List<int[]> Formations { get { return formations; } }

        protected List<int> incompatiableStartingPositions;
        public List<int> IncompatiableStartingPositions { get { return incompatiableStartingPositions; } }

        protected string name;
        public string Name { get { return name; } }

        public bool IsValid(int revealedPosition)
        {
            return !incompatiableStartingPositions.Contains(revealedPosition);
        }

        public int[] UseStrategy(int revealedPosition, Random random)
        {
            var availableFormations = 
                from formation in this.formations
                where formation.Contains(revealedPosition)
                select formation;
            int stratIndex = random.Next(availableFormations.Count());
            return availableFormations.ToList()[stratIndex];
        }
    }
}

