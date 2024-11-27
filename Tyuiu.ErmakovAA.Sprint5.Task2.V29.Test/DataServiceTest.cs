using Tyuiu.ErmakovAA.Sprint5.Task2.V29.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class UDataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\alexe\source\repos\Tyuiu.ErmakovAA.Sprint5\Tyuiu.ErmakovAA.Sprint5.Task2.V29\bin\Debug\net8.0\OutPutFileTask2.csv";
           
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}