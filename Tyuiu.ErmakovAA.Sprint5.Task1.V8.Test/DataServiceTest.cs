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

            string path = @"C:\Users\alexe\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);

            Assert.AreEqual(true, file.Exists);

        }
    }
}