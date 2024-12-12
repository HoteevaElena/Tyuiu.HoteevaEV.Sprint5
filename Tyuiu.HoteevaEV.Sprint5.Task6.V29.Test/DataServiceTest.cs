using Tyuiu.HoteevaEV.Sprint5.Task6.V29.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod] 
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V29.txt";

            var res = ds.LoadFromDataFile(path);
            
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V29.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}