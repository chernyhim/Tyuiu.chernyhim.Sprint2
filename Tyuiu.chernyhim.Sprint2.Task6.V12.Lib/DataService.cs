using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            if (n != 1 && n>10 && m>=10)
            {
                res = Convert.ToString((n - 1) + "." + m + "." + g);                
            }
            else if (n != 1 && m>=10)
            {
                res = Convert.ToString("0" + (n - 1) + "." + m + "." + g);
            }
            else if (n != 1)
            {
                res = Convert.ToString("0" + (n - 1) + ".0" + m + "." + g);
            }
            else
            {
                res = m switch
                {
                    2 => Convert.ToString("31.0" + (m - 1) + "." + g),
                    4 => Convert.ToString("31.0" + (m - 1) + "." + g),
                    6 => Convert.ToString("31.0" + (m - 1) + "." + g),
                    8 => Convert.ToString("31.0" + (m - 1) + "." + g),
                    9 => Convert.ToString("31.0" + (m - 1) + "." + g),
                    11 => Convert.ToString("31." + (m - 1) + "." + g),
                    3 => Convert.ToString("29.0" + (m - 1) + "." + g),
                    5 => Convert.ToString("30.0" + (m - 1) + "." + g),
                    7 => Convert.ToString("30.0" + (m - 1) + "." + g),
                    10 => Convert.ToString("30.0" + (m - 1) + "." + g),
                    12 => Convert.ToString("30." + (m - 1) + "." + g),
                    1 => Convert.ToString("31.12." + (g - 1)),
                    _ => "Невозможная дата"
                };
            }
            return res;           
            
        }
    }
}
