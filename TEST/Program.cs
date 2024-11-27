using System;
using System.IO;
namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
            string[] strings = text.Split(',');
            List<string> oddNumbers = new List<string>();
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
                {
                    oddNumbers.Add(str);
                }
            }
            File.WriteAllLines(@"C:\DataSprint5\InPutDataFileTask4V0.txt", oddNumbers);
            Console.WriteLine(String.Join("\n", oddNumbers));
        }
    }
}



using Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopVaule = -5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopVaule = " + stopVaule);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopVaule);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}


using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib

{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((4 - 2 * x) + (2 + Math.Cos(x) / 2 * x - 2), 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }

                return path;
            }
        }
    }
}

using System.IO;
using Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task1.V8\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);

            Assert.AreEqual(true, file.Exists);

        }
    }
}