using Application.Zadanie.Model;
using Domain.Entities.Interfaces;

namespace Application.Zadanie.Interface
{
    public interface IZadanieFactory
    {
        IZadanie Create(ZadanieModel zadanieModel);
    }
}
