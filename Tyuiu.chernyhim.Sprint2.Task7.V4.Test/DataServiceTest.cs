using Tyuiu.chernyhim.Sprint2.Task7.V4.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestDots()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.2, 0.2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(99, 99));
            Assert.AreEqual(true,ds.CheckDotInShadedArea(-0.5, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.7, -0.2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-0.7, -0.2));
        }
    }
}
