using Infrastructure.Services.CsvFileService.Interface;

namespace Infrastructure.Services.CsvFileService
{
    public class FileLoad : IFileLoad
    {
        private StreamReader FileOpenOrCreateAndOpen(string fileName)
        {
            if (!File.Exists(fileName))
            {
                var creater = File.CreateText(fileName);
                creater.Close();
            }
            StreamReader file = File.OpenText(fileName);
            return file;
        }

        private List<string> ReadTextFileToList(StreamReader stream)
        {
            List<string> list = new List<string>();
            while (stream.EndOfStream == false)
            {
                string line = stream.ReadLine();
                if (line == null || line == string.Empty)
                {
                    break;
                }
                list.Add(line);
            }
            return list;
        }
        public List<string> Load(string fileName)
        {
            StreamReader file = FileOpenOrCreateAndOpen(fileName);
            List<string> result = ReadTextFileToList(file);
            file.Close();
            return result;
        }
    }
}
