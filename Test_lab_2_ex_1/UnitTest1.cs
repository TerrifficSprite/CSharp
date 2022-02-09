using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_2_ex_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RightStudent()
        {
            Assert.AreEqual("Дiана", lab_2_ex1.Program.getStudentByLastname("Кожокар"));
            Assert.AreEqual("Михайло", lab_2_ex1.Program.getStudentByLastname("Софронiй"));
            Assert.AreEqual("Такого прiзвища у нашiй групi немає",
                lab_2_ex1.Program.getStudentByLastname("ААА"));
        }
    }
}