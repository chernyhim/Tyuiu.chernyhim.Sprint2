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
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 1, 1), "31.12.2024");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 3, 1), "29.02.2025");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 4, 1), "31.03.2025");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 5, 1), "30.04.2025");
            Assert.AreEqual(ds.FindDateOfPreviousDay(2025, 11, 11), "10.11.2025");
        }
    }
}
