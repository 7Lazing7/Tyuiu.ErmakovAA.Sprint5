using System.IO;
using System.Net.Mail;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ErmakovAA.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)

        {
         
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] nums = line.Split(' ');
                    foreach (string s in nums)
                    {
                        if (s.Length == 8)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
