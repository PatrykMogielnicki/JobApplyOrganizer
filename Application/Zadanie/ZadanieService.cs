using Application.Zadanie.Interface;
using Application.Zadanie.Model;
using Domain.Entities.Interfaces;

namespace Application.Zadanie
{
    public class ZadanieService : IZadanieService
    {
        public ZadanieService(IZadanieFactory Factory, IZadanieRepository Repository, IZadanieSave Save, IZadanieLoad Load)
        {
            _name = "lista_cv";
            _factory = Factory;
            _repository = Repository;
            _save = Save;
            _load = Load;
        }
        public void Create(ZadanieModel zadanieModel)
        {
            IZadanie newZadanie = _factory.Create(zadanieModel);
            _repository.Add(newZadanie);
        }

        public void Update(IZadanie zadanie)
        {
            _repository.Update(zadanie);
        }

        public void Delete(IZadanie zadanie)
        {
            _repository.Delete(zadanie);
        }

        public List<IZadanie> GetAll()
        {
            return _repository.GetList();
        }

        public void Save()
        {
            _save.Save(_name, _repository);
        }

        public void Load()
        {
            _load.Load(_name, _repository);
        }

        private string _name;
        private readonly IZadanieFactory _factory; // singleton
        private readonly IZadanieRepository _repository;
        private readonly IZadanieLoad _load; // singleton
        private readonly IZadanieSave _save; // singleton

        public string Name { get { return _name; }}
    }
}
