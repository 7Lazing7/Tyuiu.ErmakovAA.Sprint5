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
            string path = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}