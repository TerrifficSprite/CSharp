using System.Collections;
using lab_5_ex_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab_5_ex_2;
[TestClass]
public class UnitTest1
{
    ArrayList exhibitonDays = new ArrayList(new ExhibitionDay[] {
        new ExhibitionDay("Назва 1", "Призвище 1", "Понедiлок", 5, "Коментар 1"),
        new ExhibitionDay("Назва 2", "Призвище 2", "Вiвторок", 2, "Коментар 2"),
        new ExhibitionDay("Назва 3", "Призвище 3", "Середа", 4, "Коментар 3"),
        new ExhibitionDay("Назва 4", "Призвище 4", "Четвер", 3, "Коментар 4"),
        new ExhibitionDay("Назва 5", "Призвище 5", "П'ятниця", 5, "Коментар 5"),
    });

    private Exhibition exhibition = new Exhibition();
    
    [TestMethod]
    public void FindMinVisitersDayTest()
    {
        ExhibitionDay testExhibition = new ExhibitionDay("Назва 2", "Призвище 2", 
            "Вiвторок", 2, "Коментар 2");
        Assert.AreEqual(testExhibition.VisitersCount, 
            exhibition.FindMinVisitersDay(exhibitonDays).VisitersCount);
    }

    [TestMethod]
    public void AllVisiters()
    {
        Assert.AreEqual(19, exhibition.AllVisiters(exhibitonDays));
    }
}