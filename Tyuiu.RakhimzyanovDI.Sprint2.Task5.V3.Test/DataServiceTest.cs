using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RakhimzyanovDI.Sprint2.Task5.V3.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("среда", ds.FindDayName(3));
            Assert.AreEqual("четверг", ds.FindDayName(4));
            Assert.AreEqual("пятница", ds.FindDayName(5));
            Assert.AreEqual("суббота", ds.FindDayName(6));
            Assert.AreEqual("воскресенье", ds.FindDayName(7));

            try
            {
                ds.FindDayName(-1);
                Assert.Fail("1-7");
            }
            catch (ArgumentException)
            {
            }

            try
            {
                ds.FindDayName(8);
                Assert.Fail("1-7");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}
