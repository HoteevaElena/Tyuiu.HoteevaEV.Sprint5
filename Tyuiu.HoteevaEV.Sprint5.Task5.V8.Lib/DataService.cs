using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.HoteevaEV.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double min = 1000000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if(Convert.ToDouble(line.Replace(".", ",")) < min)
                    {
                        min = Math.Round((Convert.ToDouble(line.Replace(".", ","))), 3);
                    }
                }
            }
            return min;
        }
    }
}
