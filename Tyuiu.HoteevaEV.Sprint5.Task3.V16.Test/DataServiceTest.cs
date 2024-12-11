using Tyuiu.HoteevaEV.Sprint5.Task3.V16.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Elena\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}