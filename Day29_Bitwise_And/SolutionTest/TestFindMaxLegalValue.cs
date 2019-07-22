using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTest
{
    [TestClass]
    public class TestFindMaxLegalValue
    {
        [TestMethod]
        public void size5_limit2_return1()
        {
            int r = Solution.FindMaxLegalValue(5, 2);
            Assert.AreEqual(r, 1);
        }

        [TestMethod]
        public void size8_limit5_return4()
        {
            int r = Solution.FindMaxLegalValue(8, 5);
            Assert.AreEqual(r, 4);
        }

        [TestMethod]
        public void size2_limit2_return0()
        {
            int r = Solution.FindMaxLegalValue(2, 2);
            Assert.AreEqual(r, 0);
        }
    }
}
