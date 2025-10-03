using Tyuiu.chernyhim.Sprint2.Task3.V29.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.253;
            var res = Math.Round(ds.Calculate(x),3);
            Assert.AreEqual(res, 70170.476);

        }
    }
}
