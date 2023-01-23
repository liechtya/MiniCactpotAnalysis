namespace MiniCactpotAnalysis
{
    public class CrossAgent : PlayingAgent
    {
        public CrossAgent()
        {
            name = "Cross Agent";
            possibleRevealStrategies.Add(new PartialXStrategy());
            possibleRevealStrategies.Add(new CornerStrategy());
            possibleRevealStrategies.Add(new EmptyCrossStrategy());
        }
    }
}