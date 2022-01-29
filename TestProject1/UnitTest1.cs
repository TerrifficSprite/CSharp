using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMinNumTest()
        {
            int[] array = {-5, 2, 0, 100, -6, 20};
            Assert.AreEqual(-6, lab_2_ex_3.Program.GetMinNum(array));
            array = new []{-5, 2, -4, 1};
            Assert.AreEqual(-5, lab_2_ex_3.Program.GetMinNum(array));
        }
    }
}