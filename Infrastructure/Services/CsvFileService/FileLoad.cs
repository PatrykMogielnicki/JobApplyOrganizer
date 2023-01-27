using Infrastructure.Services.CsvFileService.Interface;

namespace Infrastructure.Services.CsvFileService
{
    public class FileLoad : IFileLoad
    {
        public List<string> Load(string fileName)
        {
            List<string> list = new List<string>();
            if (!File.Exists(fileName))
            {
                var creater = File.CreateText(fileName);
                creater.Close();
            }
            StreamReader file = File.OpenText(fileName);
            while (file.EndOfStream == false)
            {
                string line = file.ReadLine();
                if (line == null || line == string.Empty)
                {
                    break;
                }
                list.Add(line);
            }
            file.Close();
            return list;
        }
    }
}
