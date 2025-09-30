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
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 20;
            double y = 9;
            DataService ds = new DataService();
            double wait = 0.222;
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }
    }
}
