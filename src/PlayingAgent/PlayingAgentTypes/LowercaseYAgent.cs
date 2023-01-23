namespace MiniCactpotAnalysis
{
    public class LowercaseYAgent : PlayingAgent
    {
        public LowercaseYAgent()
        {
            name = "Lowercase Y Agent";
            possibleRevealStrategies.Add(new LowercaseYStrategy());
            possibleRevealStrategies.Add(new ReverseLowercaseYStrategy());
        }
    }
}