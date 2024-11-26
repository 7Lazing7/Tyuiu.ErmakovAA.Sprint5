using System.IO;
namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFileTask0.txt";
            double x5 = 3;
            double result5 = 3 * Math.Pow(x5, 3) + 4 * Math.Pow(x5, 2) - 2 * x5 + 7;
            File.AppendAllText(outputFile, result5.ToString());

            Console.WriteLine(outputFile, result5.ToString());
        }
       
    }
}
using Tyuiu.ErmakovAA.Sprint5.Task0.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string paht = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task0.V14";
            FileInfo fileInfo = new FileInfo(paht);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;

        }
    }
}


