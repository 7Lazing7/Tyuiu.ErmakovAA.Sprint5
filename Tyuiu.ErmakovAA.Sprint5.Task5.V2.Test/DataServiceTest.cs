using Tyuiu.ErmakovAA.Sprint5.Task5.V2.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\DataSprint5\InPutDataFileTask5V2.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}