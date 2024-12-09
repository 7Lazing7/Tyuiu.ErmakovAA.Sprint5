using Tyuiu.ErmakovAA.Sprint5.Task3.V7.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\alexe\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo file = new FileInfo(path);

            Assert.AreEqual(true, file.Exists);

        }
    }
}