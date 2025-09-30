using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.chernyhim.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x<=2 || x>=14 || y<=2 || y>=14) return false;
            else
            {
                if ((y == 3 || y == 4) && ((x >= 3 && x <= 5) || x == 9)) return true;
                else
                {
                    if (y == 5 && x >= 3 && x <= 9) return true;
                    else
                    {
                        if ((y == 6 || y == 7) && ((x >= 6 && x <= 9) || x == 13)) return true;
                        else
                        {
                            if ((y == 6 && x == 3) || (y == 8 && (x >= 6 && x <= 13))) return true;
                            else
                            {
                                if ((y == 9 || y == 10) && (x == 6 || (x >= 9 && x <= 12))) return true;
                                else
                                {
                                    if ((y == 11) && ((x >= 3 && x <= 6) || (x >= 9 && x <= 12))) return true;
                                    else
                                    {
                                        if(y==12&&x>=9&&x<=12) return true;
                                        else
                                        {
                                            if((y == 13) && (x>=10 && x<=12)) return true;
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            
        }
    }
}
