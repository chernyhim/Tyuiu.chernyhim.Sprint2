using Tyuiu.chernyhim.Sprint2.Task2.V20.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 10;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);
        }
    }
}
