using Application.Zadanie.Interface;
using Application.Zadanie.Model;
using Infrastructure.Services.CsvFileService.Interface;

namespace Infrastructure.Adapters
{
    public class CsvFileServiceToZadanieLoadAdapter : IZadanieLoad
    {
        public CsvFileServiceToZadanieLoadAdapter(IFileLoad load, IZadanieFactory factory)
        {
            _factory = factory;
            _load = load;
        }

        public void Load(string name, IZadanieRepository repository)
        {
            repository.Clear();
            _load.Load(_path+Path.DirectorySeparatorChar+name+".csv").ForEach(line =>
            {
                var explore = line.Split(',');
                repository.Add(
                    _factory.Create(new ZadanieModel
                    {
                        //Id = Guid.Parse(explore[0]), TODO: jakiś problem z parsowanie guidu z stringa
                        Name = explore[1],
                        Stan = (Domain.Enums.Stage)Int32.Parse(explore[2]),
                        FileLink = explore[3],
                        Date = new List<DateTime> { DateTime.Parse(explore[4]) },
                        Description = Base64Decode(explore[5])
                    })
                );
            });
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private readonly IZadanieFactory _factory;
        private readonly IFileLoad _load;
        private readonly string _path = "Listy";
    }
}
