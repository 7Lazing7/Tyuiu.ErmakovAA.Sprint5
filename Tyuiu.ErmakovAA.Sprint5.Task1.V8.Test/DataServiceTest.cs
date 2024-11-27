using System.IO;
using Tyuiu.ErmakovAA.Sprint5.Task1.V8.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task1.V8\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);

            Assert.AreEqual(true, file.Exists);

        }
    }
}