using Tyuiu.HoteevaEV.Sprint5.Task2.V24.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Elena\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}