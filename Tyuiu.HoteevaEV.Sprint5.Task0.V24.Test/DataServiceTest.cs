using System.Diagnostics;
using System.IO;
using Tyuiu.HoteevaEV.Sprint5.Task0.V24.Lib;
namespace Tyuiu.HoteevaEV.Sprint5.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            int x = 3;

            string path = @"C:\Users\Elena\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            

            
        }
    }
}