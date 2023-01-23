namespace MiniCactpotAnalysis
{
    public class CapitalYAgent : PlayingAgent
    {
        public CapitalYAgent()
        {
            name = "Capital Y Agent";
            possibleRevealStrategies.Add(new CapitalYStrategy());
        }
    }
}