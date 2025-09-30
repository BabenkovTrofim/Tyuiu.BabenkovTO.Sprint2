using Tyuiu.BabenkovTO.Sprint2.Task4.V14.Lib;
namespace Tyuiu.BabenkovTO.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 5;
            double y = 9;
            DataService ds = new DataService();
            double wait = 611.887;
            Assert.AreEqual(wait, Math.Round(ds.Calculate(x, y), 3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 9;
            double y = 4;
            DataService ds = new DataService();
            double wait = 0.27;
            Assert.AreEqual(wait, Math.Round(ds.Calculate(x, y), 4));
        }
    }
}
