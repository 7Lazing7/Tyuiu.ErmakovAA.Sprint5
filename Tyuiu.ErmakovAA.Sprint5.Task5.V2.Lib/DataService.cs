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
                    if (double.TryParse(line.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                    {
                        // Проверяем, является ли число положительным
                        if (number > 0)
                        {
                            sum += number;
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Не удалось преобразовать строку: '{line.Trim()}'");
                    }
                }

                // Вычисление среднего значения
                if (count > 0)
                {
                    double average = sum / count;
                    return Math.Round(average, 3);
                }
                else
                {
                    Console.WriteLine("Нет положительных чисел для вычисления среднего.");
                    return 0; // Если нет положительных чисел
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
                return 0; // Возвращаем 0 в случае ошибки
            }
        }
    }
}



