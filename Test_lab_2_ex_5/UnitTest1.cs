using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_2_ex_5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMaxOfTwoTest()
        {
            Assert.AreEqual("A(1) = B(1)", lab_2_ex_5.Program.GetMaxOfTwo(1, 1));
            Assert.AreEqual("A(2) > B(-4)", lab_2_ex_5.Program.GetMaxOfTwo(2, -4));
            Assert.AreEqual("A(3) < B(8)", lab_2_ex_5.Program.GetMaxOfTwo(3, 8));
        }

        [TestMethod]
        public void GetElByCoordsTest()
        {
            int[,] array =
            {
                {-97, -14, 77},
                {83,  45, -29},
                {46, -100, -56},
                {-32, 74, 3}
            };
            
            Assert.AreEqual(-14, lab_2_ex_5.Program.GetElByCoords(array, 2, 1));
            Assert.ThrowsException<IndexOutOfRangeException>((
                () => lab_2_ex_5.Program.GetElByCoords(array, 4, 2)));
        }
    }
}