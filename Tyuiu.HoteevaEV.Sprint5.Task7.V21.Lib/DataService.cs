using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V21.txt");

            FileInfo fileinfo = new FileInfo(savepath);
            bool fileexist = fileinfo.Exists;
            if(fileexist)
            {
                File.Delete(savepath);
            }

            string sline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != '.') && (line[i] != ',') && (line[i] != '!') && (line[i] != '?') && (line[i] != '-'))
                        {
                            sline += line[i];
                        }
                    }
                    File.AppendAllText(savepath, sline + Environment.NewLine);
                    sline = "";
                }
            }
            return savepath;
        }
    }
}
