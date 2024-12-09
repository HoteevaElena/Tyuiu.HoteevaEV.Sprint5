using System.IO;
using Tyuiu.HoteevaEV.Sprint5.Task1.V3.Lib;
namespace Tyuiu.HoteevaEV.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Elena\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}