using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ErmakovAA.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine("OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0); // количество строк
            int cols = matrix.GetLength(1); // количество столбцов


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }

            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        { str += matrix[i, j] + ";"; }

                    }

                    else { str += matrix[i, j]; }
                }

                if ( i != rows - 1) { File.AppendAllText (path, str + Environment.NewLine); }

                else { File.AppendAllText(path, str); }

                str = "";


            }
            return path;
        }
    }
}



  
          

    

  
