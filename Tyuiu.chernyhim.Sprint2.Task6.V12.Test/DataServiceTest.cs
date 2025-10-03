using Tyuiu.chernyhim.Sprint2.Task6.V12.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void DateValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 1, 1), "2024.12.31");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 3, 1), "2025.2.29");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 4, 1), "2025.3.31");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 5, 1), "2025.4.30");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 11, 11), "2025.11.10");
        }
    }
}
