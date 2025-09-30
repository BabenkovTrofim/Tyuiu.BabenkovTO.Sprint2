using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task4.V14.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            var z = (x * 3 < Math.Sqrt(y) + 20) ? Math.Pow((2 + 1 / (x * x)), y) : ((y * y) - Math.Cos(x * x) + 10) / ((x * x) - Math.Sin(y * y) + 12);
            return Math.Round(z, 3);
        }
    }
}
