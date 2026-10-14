using Tyuiu.RakhimzyanovDI.Sprint2.Task2.V29.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 12;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
