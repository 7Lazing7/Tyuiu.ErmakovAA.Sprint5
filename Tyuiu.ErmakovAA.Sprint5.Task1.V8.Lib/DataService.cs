using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib;

public class DataService : ISprint5Task1V8
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
        string path = Path.Combine(paths);

        FileInfo fileInfo = new FileInfo(path);
        bool fileExist = fileInfo.Exists;
    
        if (fileExist)
        {
            File.Delete(path);
        }

        for (int x = startValue; x <= stopValue; x++)
        {
            double y = Math.Round((4 - 2 * x) + (2 + Math.Cos(x) / 2 * x - 2), 2);
            string strY = Convert.ToString(y);

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




