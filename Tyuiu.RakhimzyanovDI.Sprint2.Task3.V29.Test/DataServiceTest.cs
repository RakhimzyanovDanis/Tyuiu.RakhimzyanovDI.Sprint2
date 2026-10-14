using Tyuiu.RakhimzyanovDI.Sprint2.Task3.V29.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);
            double wait = 486.000;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.000;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.000;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -40;
            double res = ds.Calculate(x);
            double wait = -439.975;
            Assert.AreEqual(wait, res);
        }
    }
}
