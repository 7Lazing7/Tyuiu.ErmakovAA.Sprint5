using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            // string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt"; 
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);

            double res =  (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);

            res = Math.Round(res, 3);

            File.WriteAllText(path, Convert.ToString(res));
            return path;

        }
    }
}
