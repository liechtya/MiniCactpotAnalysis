using MiniCactpotAnalysis;

namespace MiniCactpotAnalysis.Test
{
    [TestClass]
    public class BoardTest
    {
        public Board TestBoard;

        public BoardTest()
        {
            Random rand = new Random();
            this.TestBoard = new Board();
        }

        [TestMethod]
        public void ValidNumberForSquareTest()
        {
            Dictionary<int, bool> testingNumsAndIfItsSet = new Dictionary<int, bool>() { 
                { -1, false },
                { 1, true},
                { 2, true},
                { 5, true},
                { 9, true},
                { 10, false} };

            foreach (var testingNumAndTest in testingNumsAndIfItsSet)
            {
                TestBoard.SetSquare(0, testingNumAndTest.Key);
                Assert.AreEqual(testingNumAndTest.Value, TestBoard.GetSquare(0).Equals(testingNumAndTest.Key));
            }
        }

        [TestMethod]
        public void ResetTest()
        {
            for(int i = 0; i < 9; i++)
            {
                TestBoard.SetSquare(i, i + 1);
                Assert.AreEqual(i + 1, TestBoard.GetSquare(i));
            }
            TestBoard.Reset();
            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(0, TestBoard.GetSquare(i));
            }
            Assert.IsTrue(TestBoard.GetOpenBoard());
        }
    }
}