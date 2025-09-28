using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if (((x >= 1 & x <= 2) & (y >= 4 & y <= 5)) | (x == 3 & ((y >= 3 & y <= 7) | y == 11)) | ((x == 4 || x == 5) & ((y >= 3 & y <= 7) | y == 11) | y == 12) | (x == 6 & (y >= 5 & y <= 11)) | ((x == 7 | x == 8) & (y >= 5 & y <= 7)) | ((x == 9) & (y >= 3 & y <= 7)) | ((x == 10) & (y >= 3 & y <= 12)) | ((x == 11 | x == 12) & (y >= 3 & y <= 11)) | ((x == 13) & (y >= 6 & y <= 8))) {
                res = true;
            }
            if (y == 12 & ((x >= 1 & x <= 3) | (x >= 6 & x <= 9) | (x >= 11 & x <= 15)))
                res = false;
            else
            {
                res = false;
            }
            return res;
        }
    }

} 
