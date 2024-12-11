using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.Metadata.Ecma335;
namespace Tyuiu.HoteevaEV.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double x = double.Parse(strX);
            double res = Math.Round((Math.Sin(x) + ((Math.Pow(x, 2)) / 2)), 3);
            return res;
        }
    }
}
