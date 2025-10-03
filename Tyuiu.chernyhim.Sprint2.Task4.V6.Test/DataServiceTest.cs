using Tyuiu.chernyhim.Sprint2.Task4.V6.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
        [TestMethod]

        public void ValidTest2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 11;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(129, res);
            
        }

    }
}
