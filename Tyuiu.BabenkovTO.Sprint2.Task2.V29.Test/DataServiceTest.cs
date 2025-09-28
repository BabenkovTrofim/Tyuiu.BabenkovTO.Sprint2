using Tyuiu.BabenkovTO.Sprint2.Task2.V29.Lib;
namespace Tyuiu.BabenkovTO.Sprint2.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 6;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
