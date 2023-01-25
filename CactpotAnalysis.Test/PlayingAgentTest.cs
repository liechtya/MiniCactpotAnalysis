using System;

namespace MiniCactpotAnalysis.Test
{
    [TestClass]
    public class CapitalYAgentTest
    {
        PlayingAgent agent;
        public CapitalYAgentTest()
        {
            agent = new CapitalYAgent();
        }
    }

    [TestClass]
    public class CrossAgentTest
    {
        PlayingAgent agent;
        public CrossAgentTest() 
        {
            agent = new CrossAgent();
        }
    }

    [TestClass]
    public class LAgentTest
    {
        PlayingAgent agent;
        public LAgentTest() 
        { 
            agent = new LAgent();
        }
    }

    [TestClass]
    public class LowercaeYAgentTest
    {
        PlayingAgent agent;
        public LowercaeYAgentTest()
        {
            agent = new LowercaseYAgent();
        }

    }

    [TestClass]
    public class MirrorLAgentTest
    {
        PlayingAgent agent;
        public MirrorLAgentTest()
        {
            agent = new MirrorLAgent();
        }

    }

    [TestClass]
    public class TAgentTest 
    {
        PlayingAgent agent;
        public TAgentTest()
        {
            agent= new TAgent();
        }
    }

}

