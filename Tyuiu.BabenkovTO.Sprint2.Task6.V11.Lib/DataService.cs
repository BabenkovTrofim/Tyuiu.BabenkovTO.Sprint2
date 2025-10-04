using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string date = "";
            switch (m)
            {
                case 1:
                    if (n == 31)
                    {
                        date = $"01.02.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n+1}.01.{g}";
                    }
                    break;
                case 2:
                    if (n == 28)
                    {
                        date = $"01.03.{g}";
                    }
                    else if (n >= 1 & n <= 27)
                    {
                        date = $"{n + 1}.02.{g}";
                    }
                    break;
                case 3:
                    if (n == 31)
                    {
                        date = $"01.04.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.03.{g}";
                    }
                    break;
                case 4:
                    if (n == 30)
                    {
                        date = $"01.05.{g}";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{n + 1}.04.{g}";
                    }
                    break;
                case 5:
                    if (n == 31)
                    {
                        date = $"01.06.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.05.{g}";
                    }
                    break;
                case 6:
                    if (n == 30)
                    {
                        date = $"01.07.{g}";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{n + 1}.06.{g}";
                    }
                    break;
                case 7:
                    if (n == 31)
                    {
                        date = $"01.08.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.07.{g}";
                    }
                    break;
                case 8:
                    if (n == 31)
                    {
                        date = $"01.09.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.08.{g}";
                    }
                    break;
                case 9:
                    if (n == 30)
                    {
                        date = $"01.10.{g}";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{n + 1}.09.{g}";
                    }
                    break;
                case 10:
                    if (n == 31)
                    {
                        date = $"01.11.{g}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.10.{g}";
                    }
                    break;
                case 11:
                    if (n == 30)
                    {
                        date = $"01.12.{g}";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{n + 1}.11.{g}";
                    }
                    break;
                case 12:
                    if (n == 31)
                    {
                        date = $"01.01.{g+1}";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{n + 1}.12.{g}";
                    }
                    break;
                default: throw new ArgumentException($"Ошибка! 1 <= m <= 12, 1 <= n <= 31. \n\rТекущие значения: m = {m} n = {n}");
 
            }
            return date;
        }
    }
}
