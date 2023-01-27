using Application.Zadanie.Model;

namespace Application.Zadanie.Interface
{
    public interface IZadanieSave
    {
        void Save(string name, IZadanieRepository repository);
    }
}
