namespace MiniCactpotAnalysis
{
    public class MirrorLAgent : PlayingAgent
    {
        public MirrorLAgent()
        {
            name = "Mirror L Agent";
            possibleRevealStrategies.Add(new MirrorSideLStrategy());
            possibleRevealStrategies.Add(new MirrorMiddleLStrategy());
        }
    }
}