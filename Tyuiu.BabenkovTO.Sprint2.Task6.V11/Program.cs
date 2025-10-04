using Tyuiu.BabenkovTO.Sprint2.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результатов из switch                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
        Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int g, m, n;
        DataService ds = new DataService();
        Console.Write("Укажите год: ");
        g = Convert.ToInt32(Console.ReadLine());
        Console.Write("Укажите месяц: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Укажите дату: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Дата следующего дня: {ds.FindDateOfNextDay(g, m, n)}");
    }
}