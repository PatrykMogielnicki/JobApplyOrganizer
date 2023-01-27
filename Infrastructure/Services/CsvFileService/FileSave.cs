using Infrastructure.Services.CsvFileService.Interface;
using System.Text;

namespace Infrastructure.Services.CsvFileService
{
    public class FileSave : IFileSave
    {
        public void Save(string fileName, StringBuilder content)
        {
            StreamWriter file = File.CreateText(fileName);
            file.WriteLine(content);
            file.Close();
        }
    }
}
