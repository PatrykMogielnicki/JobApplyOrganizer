using Application.Zadanie.Model;
using Domain.Entities.Interfaces;

namespace Application.Zadanie.Interface
{
    public interface IZadanieParser
    {
        string Parse(IZadanie zadanie);
        IZadanie Parse(IZadanie zadanie, ZadanieModel model);
    }
}
