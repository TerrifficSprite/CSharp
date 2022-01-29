using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_3_ex_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeleteWordsTest()
        {
            string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\Test_lab_3_ex_3\\";
            StreamWriter streamWriter = File.CreateText(path + "input.txt");
            streamWriter.Write("Це текстоо для теста в проектіі This is text for test project");
            streamWriter.Close();
            
            StreamReader streamReaderInput = File.OpenText(path + "input.txt");
            streamWriter = File.CreateText(path + "output.txt");
            lab_3_ex_3.Program.DeleteWords(streamReaderInput, streamWriter);
            
            StreamReader streamReaderOutput = File.OpenText(path + "output.txt");
            Assert.AreEqual("Це для теста в text test project ", 
                streamReaderOutput.ReadToEnd());
        }
    }
}