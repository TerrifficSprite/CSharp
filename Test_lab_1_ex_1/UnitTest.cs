using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 10;
            Assert.AreEqual(15, 
                ex_1.Program.Example(a, b));
        }
    }
}