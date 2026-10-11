using Tyuiu.RakhimzyanovDI.Sprint2.Task0.V20.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
