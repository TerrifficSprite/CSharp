using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace Test_lab_3_ex_2
{
    [TestClass]
    public class UnitTest1
    {
        string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_3_ex_2\\";
        private Methods lib = new Methods();
        
        [TestMethod]
        public void TenWordsTest()
        {
            StreamReader stream_ten = File.OpenText(path + "file_ten.txt");
            Assert.AreEqual("[six, S, stop]", 
                lib.ReturnArrayListToString(lab_3_ex_2.Program.TenWords(stream_ten)));
        }
        
        [TestMethod]
        public void UnknownWordsTest()
        {
            StreamReader stream = File.OpenText(path + "file.txt");
            Assert.AreEqual("[Set, six, S, stop, Set, six, SetOne, six, six]", 
                lib.ReturnArrayListToString(lab_3_ex_2.Program.UnknownWords(stream)));
        }
    }
}