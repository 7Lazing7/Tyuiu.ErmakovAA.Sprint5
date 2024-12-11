using Tyuiu.ErmakovAA.Sprint5.Task3.V7.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopVaule = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int x = 2;
            Console.WriteLine("x = " + x);
            double res = Math.Round(1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x, 3);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string result = ds.SaveToFileTextData(x);

            Console.WriteLine( "OTVET " + res);
            Console.WriteLine("Файл: " + result);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
