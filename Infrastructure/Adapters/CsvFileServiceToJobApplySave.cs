using Application.JobService.Interface;
using Infrastructure.Services.CsvFileService.Interface;
using System.Text;

namespace Infrastructure.Adapters
{
    public class CsvFileServiceToJobApplySave : IJobApplySave
    {
        public CsvFileServiceToJobApplySave(IFileSave save, IJobApplyParser parser)
        {
            _parser = parser;
            _save = save;
        }
        public void Save(string name, IJobApplyRepository repository)
        {
            _save.Save(
                CsvFilePathBuilder(name),
                ParseRepositoryToCsv(repository)
            );
        }
        private StringBuilder ParseRepositoryToCsv(IJobApplyRepository repository)
        {
            StringBuilder csv = new StringBuilder();
            repository.GetList().ForEach(zadanie =>
            {
                csv.AppendLine(_parser.Parse(zadanie));
            });
            return csv;
        }
        private string CsvFilePathBuilder(string FileName)
        {
            return _path + Path.DirectorySeparatorChar + FileName + ".csv";
        }

        private readonly IFileSave _save;
        private readonly IJobApplyParser _parser;
        //TODO: move to config file 
        private readonly string _path = "CsvFiles";  
    }
}
