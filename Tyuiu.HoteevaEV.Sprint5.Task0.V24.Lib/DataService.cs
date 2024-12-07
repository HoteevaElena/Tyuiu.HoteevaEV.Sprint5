using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.HoteevaEV.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(),"OutPutFileTask0.txt");
            double z = (((x * x * x) - 8)/(2 * (x * x)));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;   
        }
    }
}
