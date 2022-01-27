using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_2_ex_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateY()
        {
            Assert.AreEqual(104.242, Math.Round(lab_2_ex_2.Program.CalculateY(3), 3));
            Assert.AreEqual(529.768, Math.Round(lab_2_ex_2.Program.CalculateY((float)4.85), 3));
        }
    }
}