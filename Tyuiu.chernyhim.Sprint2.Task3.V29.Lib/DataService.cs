using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task3.V29.Lib
{
    public class DataService : ISprint2Task3V29
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                y = x * Math.Pow(((x + 1) / (x - 1)), 5);
            }
            else if (x == 0)
            {
                y = 5 / 5;
            }
            else if ((x > -33) && (x < 2))
            {
                y = Math.Pow((1 + (1 / (x * x))), x);
            }
            else
            {
                y = x + 10 * x - (1 / x);
            }
            return Math.Round(y, 3);
        }
    }
}
