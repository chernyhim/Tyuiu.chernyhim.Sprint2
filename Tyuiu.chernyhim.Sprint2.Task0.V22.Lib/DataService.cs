using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];            
            results[0] = x == y;  
            results[1] = x != y;   
            results[2] = y < x;    
            results[3] = x > y;    
            results[4] = y <= x;   
            results[5] = y >= x;   
            return results;
        }
    }
}
