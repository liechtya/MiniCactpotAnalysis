

namespace MiniCactpotAnalysis
{
    public class Line
    {
        private int[] linePos;
        public int[] LinePos { get { return linePos; } }
        private string name;
        public string Name { get { return name; } }
        public Line(int[] linePos, string name)
        {
            this.linePos = linePos;
            this.name = name;
        }
    }
}

