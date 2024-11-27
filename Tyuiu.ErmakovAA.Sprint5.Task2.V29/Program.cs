using Tyuiu.ErmakovAA.Sprint5.Task2.V29.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 9, 2, 5 },
                                            { 3, 2, 4 },
                                            { 2, 8, 8 } };

            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int cols = matrix.Length / rows; // количество столбцов

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
