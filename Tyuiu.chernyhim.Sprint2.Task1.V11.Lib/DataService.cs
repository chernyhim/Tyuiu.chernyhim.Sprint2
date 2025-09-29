using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {//145 156 142 117
         // |, &, ||, &&, !, ^
         //(False, False, True, False, True, False)
            bool[] results = new bool[6];
            results[0] = a > b | c < d;
            results[1] = a > b & c > d;
            results[2] = a > b && c > d;
            results[3] = a > b && c > d;
            results[4] = !(a == b);
            results[5] = a < b ^ c > d;
            return results;

        }
    }
}
