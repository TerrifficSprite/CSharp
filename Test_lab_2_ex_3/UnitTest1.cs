using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_2_ex_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinimumNumberTest()
        {
            int[] array = {-5, 2, 0, 100, -6, 20};
            Assert.AreEqual(-6, lab_2_ex_3.Program.GetMinNum(array));
            array = new []{-5, 2, -4, 1};
            Assert.AreEqual(-5, lab_2_ex_3.Program.GetMinNum(array));
        }

        [TestMethod]
        public void SumOfNegativesTest()
        {
            int[] array = {-5, 2, 0, 100, -6, 20};
            Assert.AreEqual(102, lab_2_ex_3.Program.SumBeetweenNegativeNums(array));
            array = new []{-20, 0, 10};
            Assert.AreEqual(-1, lab_2_ex_3.Program.SumBeetweenNegativeNums(array));
            array = new []{8, 2, 0};
            Assert.AreEqual(-2, lab_2_ex_3.Program.SumBeetweenNegativeNums(array));
        }
    }
}