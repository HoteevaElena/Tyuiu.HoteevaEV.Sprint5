using Tyuiu.HoteevaEV.Sprint5.Task4.V15.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}