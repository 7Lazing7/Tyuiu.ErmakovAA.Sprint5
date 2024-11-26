using Tyuiu.ErmakovAA.Sprint5.Task0.V14.Lib;
using System.IO;
namespace Tyuiu.ErmakovAA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string paht = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(paht);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
