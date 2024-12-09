using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib;

public class DataService : ISprint5Task1V8
{
    public string SaveToFileTextData (int startValue, int stopValue)
    {
        string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
        

        FileInfo fileInfo = new FileInfo(path);
        bool fileExist = fileInfo.Exists;
    
        if (fileExist)
        {
            File.Delete(path);
        }
      
        string strY;

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x != 1 && x != 1 )
            { strY = Convert.ToString(Math.Round((4 - 2 * x) + (2 + Math.Cos(x)) / (2 * x - 2), 2)); }
            else { strY = "0"; }

            if (x != stopValue)
            {
                File.AppendAllText(path, strY + Environment.NewLine);
            }

            else 
            {
                File.AppendAllText(path, strY);
            }

           
        }
        return path;
    }
    
}




//C:\Users\alexe\AppData\Local\Temp\OutPutFileTask1.txt