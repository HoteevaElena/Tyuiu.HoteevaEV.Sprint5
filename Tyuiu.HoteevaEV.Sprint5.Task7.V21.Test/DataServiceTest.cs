using Tyuiu.HoteevaEV.Sprint5.Task7.V21.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }

        [TestMethod]
        public void CheckedExistsOutPutFile()
        {
            string path = @"C:\Users\Elena\AppData\Local\Temp\OutPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}