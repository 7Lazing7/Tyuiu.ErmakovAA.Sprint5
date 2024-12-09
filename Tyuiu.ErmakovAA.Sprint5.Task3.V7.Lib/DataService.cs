using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });


            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            if (x == 2)
            {
                double res = Math.Round(1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x, 3);

                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    writer.Write(BitConverter.GetBytes(res));
                }



                
            }
            return path;
        }
    }
}