using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_3_ex_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountVowelWordsTest()
        {
            Assert.AreEqual(2, lab_3_ex_1.Program.CountVowelWords("One two three oOoo"));
            Assert.AreEqual(0, lab_3_ex_1.Program.CountVowelWords("Test text"));
        }
    }
}