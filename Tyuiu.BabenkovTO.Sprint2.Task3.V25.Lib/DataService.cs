using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            double y = 0;
            if(x > 1)
            {
                y = Math.Sin(Math.Pow(x, 3)) + Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if(x > -29 & x < 2)
            { 
                if (x == 0)
                {
                    y = x * x - ((Math.Cos(Math.Pow(x, 3))) / (x - 3));
                }
                else
                {
                    y = Math.Pow((1 + (1 / (x * x))), x);
                }
            }
            else
            {
                y = x + 15 + (12 / x) * x;
            }
            return Math.Round(y, 3);
        }
    }
}
