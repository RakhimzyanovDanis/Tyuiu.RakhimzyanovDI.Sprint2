using Tyuiu.RakhimzyanovDI.Sprint2.Task7.V2.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = -0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
