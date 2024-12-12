using System.IO;
using System.Net.Mail;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)

        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            path = Path.Combine("InPutDataFileTask6V30.txt");

            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                    count += words.Count(word => word.Length == 8);
                }
                return count;


            }
        }
    }
}
