using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {

        public double LoadFromDataFile(string path)
        {
            try
            {
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(path);
                double sum = 0;
                int count = 0;

                foreach (var line in lines)
                {
                    // Пробуем преобразовать строку в число
                    if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                    {
                        // Проверяем, является ли число положительным
                        if (number > 0)
                        {
                            sum += number;
                            count++;
                        }
                    }
                }

                // Вычисление среднего значения
                double average = count > 0 ? sum / count : 0;

                // Округление до трёх знаков после запятой
                return Math.Round(average, 3);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return 0; // Возвращаем 0 в случае ошибки
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataService loader = new DataService();
            string filePath = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
            double average = loader.LoadFromDataFile(filePath);
            Console.WriteLine($"Среднее всех положительных значений: {average}");
        }
    }
}
