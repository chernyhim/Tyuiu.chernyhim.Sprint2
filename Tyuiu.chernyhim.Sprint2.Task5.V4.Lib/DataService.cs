using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1:
                    return "Пики";
                case 2:
                    return "Трефы";
                case 3:
                    return "Бубны";
                case 4:
                    return "Червы";
                default:
                    return "Нет такой масти";
                                            
            }
        }
    }
}
