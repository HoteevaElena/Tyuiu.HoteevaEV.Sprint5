using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Runtime.InteropServices;
namespace Tyuiu.HoteevaEV.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";
            for(int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    if(y != columns - 1)
                    {
                        str += matrix[x, y] + ";";
                    }
                    else
                    {
                        str += matrix[x, y];
                    }
                }

                if(x != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }

            return path;

        }
    }
}
