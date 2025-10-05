using Tyuiu.BabenkovTO.Sprint2.Task7.V13.Lib;
namespace Tyuiu.BabenkovTO.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 0.8;
            bool wait = true;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}
