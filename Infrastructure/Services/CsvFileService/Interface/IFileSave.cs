using System.Text;

namespace Infrastructure.Services.CsvFileService.Interface
{
    public interface IFileSave
    {
        void Save(string fileName, StringBuilder content);
    }
}
