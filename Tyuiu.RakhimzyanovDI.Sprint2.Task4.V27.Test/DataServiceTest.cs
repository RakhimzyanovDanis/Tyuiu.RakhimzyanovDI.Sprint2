using Tyuiu.RakhimzyanovDI.Sprint2.Task4.V27.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = -10;
            double res = ds.Calculate(x, y);
            double wait = 20.000;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 99.867;
            Assert.AreEqual(wait, res);
        }
    }
}
