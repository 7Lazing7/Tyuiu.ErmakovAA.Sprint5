using System.IO;
using Tyuiu.ErmakovAA.Sprint5.Task6.V30.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
   
            [TestMethod]
            public void ValidCalc()
            {
                DataService ds = new DataService();
                string[] paths = { @"C:\DataSprint5\InPutDataFileTask6V29.txt" };
                string fullPath = Path.Combine(paths);

                var res = ds.LoadFromDataFile(fullPath);
                int wait = 0;
                Assert.AreEqual(wait, res);



            }

            [TestMethod]
            public void LoadFromDataFile()
            {
                string[] paths = { @"C:\DataSprint5\InPutDataFileTask6V29.txt" };
                string fullPath = Path.Combine(paths);

                FileInfo fileInfo = new FileInfo(fullPath);
                bool fileExist = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExist);

            }
        }
    }
