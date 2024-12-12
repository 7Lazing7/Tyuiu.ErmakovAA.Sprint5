using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Путь к файлу
        string filePath = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\TEST\bin\Debug\net8.0\InPutDataFileTask4V0.txt";

        // Чтение текста из файла
        string text = File.ReadAllText(filePath);

        // Разделение текста на строки
        string[] strings = text.Split(',');

        // Список для четных чисел
        List<string> oddNumbers = new List<string>();

        // Обработка каждой строки
        foreach (string str in strings)
        {
            // Если строка может быть преобразована в число
            if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
            {
                // Добавление четного числа в список
                oddNumbers.Add(str.Trim());
            }
        }

        // Перезапись файла только с четными числами
        File.WriteAllLines(filePath, oddNumbers);

        // Вывод четных чисел в консоль
        Console.WriteLine(string.Join("\n", oddNumbers));

        // Ожидание нажатия клавиши перед выходом
        Console.ReadKey();
    }
}





/* // Путь к файлу
        string filePath = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\TEST\bin\Debug\net8.0\InPutDataFileTask4V0.txt";

        // Чтение текста из файла
        string text = File.ReadAllText(filePath);

        // Разделение текста на строки
        string[] strings = text.Split(',');

        // Список для четных чисел
        List<string> oddNumbers = new List<string>();

        // Обработка каждой строки
        foreach (string str in strings)
        {
            // Если строка может быть преобразована в число
            if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
            {
                // Добавление четного числа в список
                oddNumbers.Add(str.Trim());
            }
        }

        // Перезапись файла только с четными числами
        File.WriteAllLines(filePath, oddNumbers);

        // Вывод четных чисел в консоль
        Console.WriteLine(string.Join("\n", oddNumbers));

        // Ожидание нажатия клавиши перед выходом
        Console.ReadKey();
*/