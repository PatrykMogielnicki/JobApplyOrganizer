using Application.Zadanie.Model;

namespace Application.Zadanie.Interface
{
    public interface IZadanieLoad
    {
        void Load(string name, IZadanieRepository repository);
    }
}
