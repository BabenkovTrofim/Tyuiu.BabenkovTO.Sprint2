using Tyuiu.BabenkovTO.Sprint2.Task6.V11.Lib;
namespace Tyuiu.BabenkovTO.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2007;
            int m = 6;
            int n = 13;
            string wait = "2007 Июнь 14";
            Assert.AreEqual(wait, ds.FindDateOfNextDay(g, m, n));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(g, 20, 0));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(g, -10, 32));
        }
    }
}
