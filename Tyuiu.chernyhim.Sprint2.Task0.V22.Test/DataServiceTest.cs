using Tyuiu.chernyhim.Sprint2.Task0.V22.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x, y;
            x = 3105;
            y = 77;
            var res = ds.GetCompareOperations(x, y);
            bool[] ans = { false, true, true, true, true, false };
            
        }
    }
}
