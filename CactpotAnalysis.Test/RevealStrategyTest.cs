
namespace MiniCactpotAnalysis.Test
{
    [TestClass]
    public class CapitalYStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public CapitalYStrategyTest()
        {
            testStrategy = new CapitalYStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class CornerStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public CornerStrategyTest()
        {
            testStrategy = new CornerStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, false },
                { 2, true },
                { 3, false },
                { 4, false },
                { 5, false },
                { 6, true },
                { 7, false },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class EmptyCrossStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public EmptyCrossStrategyTest()
        {
            testStrategy = new EmptyCrossStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, false },
                { 1, true },
                { 2, false },
                { 3, true },
                { 4, false },
                { 5, true },
                { 6, false },
                { 7, true },
                { 8, false },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
               if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class LowercaseYStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public LowercaseYStrategyTest()
        {
            testStrategy = new LowercaseYStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class MiddleLStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public MiddleLStrategyTest()
        {
            testStrategy = new MiddleLStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class MirrorMiddleLStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public MirrorMiddleLStrategyTest()
        {
            testStrategy = new MirrorMiddleLStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                pickedFormation = testStrategy.UseStrategy(num, rnd);
                Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
            }
            
        }
    }

    [TestClass]
    public class MirrorSideLStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public MirrorSideLStrategyTest()
        {
            testStrategy = new MirrorSideLStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, false },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class PartialXStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public PartialXStrategyTest()
        {
            testStrategy = new PartialXStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, false },
                { 2, true },
                { 3, false },
                { 4, true },
                { 5, false },
                { 6, true },
                { 7, false },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class ReverseLowercaseYStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public ReverseLowercaseYStrategyTest()
        {
            testStrategy = new ReverseLowercaseYStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class ShortTStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public ShortTStrategyTest()
        {
            testStrategy = new ShortTStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, true },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }

    [TestClass]
    public class SideLStrategyTest
    {
        RevealStrategy testStrategy;
        Random rnd;
        public SideLStrategyTest()
        {
            testStrategy = new SideLStrategy();
            rnd = new Random();
        }

        [TestMethod]
        public void IsValidTest()
        {
            Dictionary<int, bool> testValueAndTests = new Dictionary<int, bool>()
            {
                { 0, true },
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, false },
                { 5, true },
                { 6, true },
                { 7, true },
                { 8, true },
            };
            foreach (var testPair in testValueAndTests)
            {
                Assert.AreEqual(testPair.Value, testStrategy.IsValid(testPair.Key), $"IsValid(): {testPair.Key} is suppose to be {testPair.Value} but is {testStrategy.IsValid(testPair.Key)}");
            }
        }

        [TestMethod]
        public void UseStrategyTest()
        {
            int[] pickedFormation;
            for (int num = 0; num < 9; num++)
            {
                if (testStrategy.IsValid(num))
                {
                    pickedFormation = testStrategy.UseStrategy(num, rnd);
                    Assert.IsTrue(pickedFormation.Contains(num), $"The revealed number {num} is not contained in the picked formation");
                }
            }
            
        }
    }
}
