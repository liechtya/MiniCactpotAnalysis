namespace MiniCactpotAnalysis {
    public class LAgent: PlayingAgent
    {
        public LAgent()
        {
            name = "L Agent";
            possibleRevealStrategies.Add(new SideLStrategy());
            possibleRevealStrategies.Add(new MiddleLStrategy());
        }
    }
}

