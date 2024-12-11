using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
namespace Tyuiu.ErmakovAA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double ret = Math.Round (Math.Pow((Convert.ToDouble (strX) / Math.Cos(Convert.ToDouble(strX))), 2),3);
           
            return ret;
        }
    }
}
