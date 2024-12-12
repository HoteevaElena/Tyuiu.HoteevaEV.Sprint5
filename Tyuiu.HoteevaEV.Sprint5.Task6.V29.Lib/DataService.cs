using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] s = line.Split(" ").ToArray();
                    for(int i = 0; i < s.Length; i++)
                    {
                        if (s[i].Length == 7)
                        {
                            count += 1;
                        }
                    }
                }
            }
            return count;
        }
    }
}
