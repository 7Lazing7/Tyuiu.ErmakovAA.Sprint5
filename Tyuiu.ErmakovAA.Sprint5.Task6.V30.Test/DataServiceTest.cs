using System.IO;
using Tyuiu.ErmakovAA.Sprint5.Task6.V30.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
     
        [TestMethod]
        public void ValideCalc()
        {
            string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask6V13.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}