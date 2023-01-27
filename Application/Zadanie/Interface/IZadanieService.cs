using Application.Zadanie.Model;
using Domain.Entities.Interfaces;

namespace Application.Zadanie.Interface
{
    public interface IZadanieService
    {
        void Create(ZadanieModel zadanieModel);
        void Update(IZadanie zadanieModel);
        void Delete(IZadanie zadanieModel);
        List<IZadanie> GetAll();
        void Load();
        void Save();
        string Name { get;}
    }
}
