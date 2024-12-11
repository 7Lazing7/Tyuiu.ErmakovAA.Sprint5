using Tyuiu.ErmakovAA.Sprint5.Task4.V19.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\alexe\AppData\Local\Temp\InPutDataFileTask4V19.txt";

            FileInfo file = new FileInfo(path);

            Assert.AreEqual(true, file.Exists);

        }
    }
}