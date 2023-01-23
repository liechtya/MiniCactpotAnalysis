
namespace MiniCactpotAnalysis.Test
{
    [TestClass]
    public class BoardPlayerTest
    {
        BoardPlayer testBoardPlayer;
        Random rand;
        public BoardPlayerTest()
        {
            this.rand = new Random();
            this.testBoardPlayer = new BoardPlayer(rand);
        }

        [TestMethod]
        public void ProceedRevealedNumTest()
        {
            int[] positions = new int[] { 0, 4, 7 };
            testBoardPlayer.Proceed(positions, rand);
            int revealedNums = 0;
            foreach (var item in testBoardPlayer.GetBoardValues())
            {
                if(item > 0 )
                {
                    revealedNums++;
                }
            }
            Assert.AreEqual(4, revealedNums, $"BoardPlayer.Proceed() should not end up with {revealedNums} revealed numbers. Positiones passed are {string.Join(", ", positions)}");
        }

        [TestMethod]
        public void CompleteTheBoardTest()
        {
            int[] positions = new int[] { 0, 4, 7 };
            testBoardPlayer.Proceed(positions, rand);
            testBoardPlayer.CompleteTheBoard(rand);
            int revealedNums = 0;
            foreach (var item in testBoardPlayer.GetBoardValues())
            {
                if (item > 0)
                {
                    revealedNums++;
                }
            }
            Assert.AreEqual(9, revealedNums, $"BoardPlayer.CompleteTheBoard() should not end up with {revealedNums} revealed numbers. Positiones passed are {string.Join(", ", positions)}");
        }
    }

}
