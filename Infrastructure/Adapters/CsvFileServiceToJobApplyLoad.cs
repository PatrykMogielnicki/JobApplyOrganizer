using Application.Common;
using Application.JobService.Interface;
using Application.JobService.Model;
using Infrastructure.Services.CsvFileService.Interface;

namespace Infrastructure.Adapters
{
    public class CsvFileServiceToJobApplyLoad : IJobApplyLoad
    {
        public CsvFileServiceToJobApplyLoad(IFileLoad load, IJobApplyFactory factory)
        {
            _factory = factory;
            _load = load;
        }

        public void Load(string name, IJobApplyRepository repository)
        {
            repository.Clear();
            _load.Load(CsvFilePathBuilder(name)).ForEach(line =>
            {
                repository.Add(
                    _factory.Create(
                        ParseStringLineToObject(line)
                    )
                );
            });
        }
        private JobApplyModel ParseStringLineToObject(string line)
        {
            var explore = line.Split(',');
            return new JobApplyModel
            {
                //TODO: problem with parsing guid from string
                //Id = Guid.Parse(explore[0]), 
                Name = explore[1],
                Stan = (Domain.Enums.Stage)Int32.Parse(explore[2]),
                FileLink = explore[3],
                Date = DateTime.Parse(explore[4]),
                Description = Base64Parser.Decode(explore[5])
            };
        }
        private string CsvFilePathBuilder(string FileName)
        {
            return _path + Path.DirectorySeparatorChar + FileName + ".csv";
        }

        private readonly IJobApplyFactory _factory;
        private readonly IFileLoad _load;
        //TODO get directory name from config
        private readonly string _path = "CsvFiles";
    }
}
