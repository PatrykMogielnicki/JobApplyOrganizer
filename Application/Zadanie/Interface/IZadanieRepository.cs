using Domain.Entities.Interfaces;

namespace Application.Zadanie.Interface
{
    public interface IZadanieRepository
    {
        List<IZadanie> GetList();
        void Add(IZadanie zadanie);
        void Update(IZadanie zadanie);
        void Delete(IZadanie zadanie);
        int Count { get; }
        void Clear();
        IZadanie GetByName(string name);

    }
}
