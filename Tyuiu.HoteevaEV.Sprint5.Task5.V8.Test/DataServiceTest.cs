using Tyuiu.HoteevaEV.Sprint5.Task5.V8.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}