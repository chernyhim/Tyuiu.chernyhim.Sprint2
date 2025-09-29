using Tyuiu.chernyhim.Sprint2.Task1.V11.Lib;
namespace Tyuiu.chernyhim.Sprint2.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            //145 156 142 117
            // |, &, ||, &&, !, ^
            //(False, False, True, False, True, False)
            DataService ds = new DataService();
            int x, y, z, w;
            x = 145;
            y = 156;
            z = 142;
            w = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(x,y,z,w);
            bool[] wait = { false, false, true, false, true, false };
            
        }
    }
}
