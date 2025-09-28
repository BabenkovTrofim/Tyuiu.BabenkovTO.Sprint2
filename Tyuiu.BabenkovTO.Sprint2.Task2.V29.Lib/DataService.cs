using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3 & x <= 12) & (y >= 5 & y <= 7)) || ((x >= 10 & x <= 12) & (y >= 8 & y <= 11)) || ((x >= 9 & x <= 12) & (y >= 3 & y <= 4)) || ((x >= 3 & x <= 5) & (y >= 3 & y <= 4)) || ((x >= 1 & x <= 2) & (y >= 4 & y <= 5)) || ((x == 13) & (y >= 6 & y <= 8)) || ((x == 6) & (y >= 8 & y <= 11)) || ((y == 11) & (x >= 3 & x <= 5)) || ((y == 12) & (x >= 4 & x <= 5)) || (x == 10 & y == 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }

} 
