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
                        date = $"{g} Февраль 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Январь {n+1}";
                    }
                    break;
                case 2:
                    if (n == 28)
                    {
                        date = $"{g} Март 1";
                    }
                    else if (n >= 1 & n <= 27)
                    {
                        date = $"{g} Февраль {n+1}";
                    }
                    break;
                case 3:
                    if (n == 31)
                    {
                        date = $"{g} Апрель 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Март {n+1}";
                    }
                    break;
                case 4:
                    if (n == 30)
                    {
                        date = $"{g} Май 1";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{g} Апрель {n+1}";
                    }
                    break;
                case 5:
                    if (n == 31)
                    {
                        date = $"{g} Июнь 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Май {n+1}";
                    }
                    break;
                case 6:
                    if (n == 30)
                    {
                        date = $"{g} Июль 1";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{g} Июнь {n+1}";
                    }
                    break;
                case 7:
                    if (n == 31)
                    {
                        date = $"{g} Август 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Июль {n+1}";
                    }
                    break;
                case 8:
                    if (n == 31)
                    {
                        date = $"{g} Сентябрь 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Август {n+1}";
                    }
                    break;
                case 9:
                    if (n == 30)
                    {
                        date = $"{g} Октябрь 1";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{g} Сентябрь {n+1}";
                    }
                    break;
                case 10:
                    if (n == 31)
                    {
                        date = $"{g} Ноябрь 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Октябрь {n+1}";
                    }
                    break;
                case 11:
                    if (n == 30)
                    {
                        date = $"{g} Декабрь 1";
                    }
                    else if (n >= 1 & n <= 29)
                    {
                        date = $"{g} Ноябрь {n+1}";
                    }
                    break;
                case 12:
                    if (n == 31)
                    {
                        date = $"{g+1} Январь 1";
                    }
                    else if (n >= 1 & n <= 30)
                    {
                        date = $"{g} Декабрь {n+1}";
                    }
                    break;
                default: throw new ArgumentException($"Ошибка! 1 <= m <= 12, 1 <= n <= 31. \n\rТекущие значения: m = {m} n = {n}");
 
            }
            return date;
        }
    }
}
