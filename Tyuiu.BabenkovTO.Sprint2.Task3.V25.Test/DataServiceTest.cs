using Tyuiu.BabenkovTO.Sprint2.Task3.V25.Lib;
namespace Tyuiu.BabenkovTO.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6;
            double wait = 8.226;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.333;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -6;
            double wait = 0.848;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -40;
            double wait = -13;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
