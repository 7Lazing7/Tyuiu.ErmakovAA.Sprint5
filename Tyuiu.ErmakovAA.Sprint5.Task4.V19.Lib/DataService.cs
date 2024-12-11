using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
namespace Tyuiu.ErmakovAA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            
            double ret = Math.Pow((Convert.ToDouble (strx) / Math.Cos(Convert.ToDouble(strx))), 2);
            Math.Round (ret, 3);
            return ret;
        }
    }
}
