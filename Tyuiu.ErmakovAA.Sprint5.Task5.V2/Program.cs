using Tyuiu.ErmakovAA.Sprint5.Task5.V2.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #19                                                                  *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
           
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Среднее всех положительных значений: " + res);
            Console.ReadKey();


            DataService loader = new DataService();
                string filePath = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
                double average = loader.LoadFromDataFile(filePath);
                Console.WriteLine($"Среднее всех положительных значений: {average}");
           
        }
    }
}