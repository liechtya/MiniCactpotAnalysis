namespace MiniCactpotAnalysis
{
    public class TAgent : PlayingAgent
    {
        public TAgent()
        {
            name = "T Agent";
            possibleRevealStrategies.Add(new ShortTStrategy());
        }
    }
}