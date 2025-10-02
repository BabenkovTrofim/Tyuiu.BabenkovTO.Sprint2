using Tyuiu.BabenkovTO.Sprint2.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
        Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,масти «червы» —  *");
        Console.WriteLine("* 4. По заданному номеру масти m (1 <= m <= 4) определить название        *");
        Console.WriteLine("* соответствующей масти.                                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int num;
        Console.Write("Укажите номер масти: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        Console.WriteLine($"Номер: {num} \n\rМасть: {ds.FindCardSuit(num)}");
    }
}