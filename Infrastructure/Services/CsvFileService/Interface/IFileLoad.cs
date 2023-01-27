namespace Infrastructure.Services.CsvFileService.Interface
{
    public interface IFileLoad
    {
        List<string> Load(string fileName);
    }
}
