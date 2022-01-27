using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_ex_2
{
    [TestClass]
    public class UnitTest
    {
        // Точки
        private static int x1 = 0;
        private static int y1 = 0;
        private static int x2 = 0;
        private static int y2 = 3;
        private static int x3 = 4;
        private static int y3 = 0;
        // Відрізки
        float AB = ex_2.Program.lengthByDotes(x1, y1, x2, y2);
        float BC = ex_2.Program.lengthByDotes(x2, y2, x3, y3);
        float AC = ex_2.Program.lengthByDotes(x1, y1, x3, y3);

        [TestMethod]
        public void SquareTest()
        {
            // Площа
            Assert.AreEqual(6, ex_2.Program.square(AB, BC, AC));
        }

        [TestMethod]
        public void PerimeterTest()
        {
            // Периметр
            Assert.AreEqual(12, ex_2.Program.perimeter(AB, BC, AC));
        }

        [TestMethod]
        public void LengthByDotesTest()
        {
            Assert.AreEqual(3, ex_2.Program.lengthByDotes(x1, y1, x2, y2));
            Assert.AreEqual(5, ex_2.Program.lengthByDotes(x2, y2, x3, y3));
            Assert.AreEqual(4, ex_2.Program.lengthByDotes(x1, y1, x3, y3));
        }
    }
}