using Application.Zadanie.Interface;
using Application.Zadanie.Model;
using Infrastructure.Services.CsvFileService;
using Infrastructure.Services.CsvFileService.Interface;
using System.Text;

namespace Infrastructure.Adapters
{
    public class CsvFileServiceToZadanieSaveAdapter : IZadanieSave
    {
        public CsvFileServiceToZadanieSaveAdapter(IFileSave save, IZadanieParser parser)
        {
            _parser = parser;
            _save = save;
        }
        public void Save(string name, IZadanieRepository repository)
        {
            StringBuilder csv = new StringBuilder();
            repository.GetList().ForEach(zadanie =>
            {
                csv.AppendLine(_parser.Parse(zadanie));
            });
            _save.Save(_path+Path.DirectorySeparatorChar+name+".csv", csv);
        }

        private readonly IFileSave _save;
        private readonly IZadanieParser _parser;
        private readonly string _path = "Listy";  //TODO: przeniesc do pliku konfiguracyjnego, przekazywac przez konstruktor, najlepiej przes zmienna w metodzie
    }
}
