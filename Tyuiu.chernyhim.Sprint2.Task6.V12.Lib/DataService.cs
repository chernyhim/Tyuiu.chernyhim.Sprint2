using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            if (n != 1)
            {                
                res = Convert.ToString(g + "." + m + "." + (n - 1));                
            }
            else
            {
                res = m switch
                {
                    2 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    4 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    6 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    8 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    9 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    11 => Convert.ToString(g + "." + (m - 1) + "." + 31),
                    3 => Convert.ToString(g + "." + (m - 1) + "." + 29),
                    5 => Convert.ToString(g + "." + (m - 1) + "." + 30),
                    7 => Convert.ToString(g + "." + (m - 1) + "." + 30),
                    10 => Convert.ToString(g + "." + (m - 1) + "." + 30),
                    12 => Convert.ToString(g + "." + (m - 1) + "." + 30),
                    1 => Convert.ToString((g - 1) + "." + 12 + "." + 31),
                    _=>"нет такого месяца"
                };                
            }
            return res;
            

        
            
        }
    }
}
