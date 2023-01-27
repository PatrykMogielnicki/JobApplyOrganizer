using Application.Zadanie.Interface;
using Application.Zadanie.Model;
using Domain.Entities.Interfaces;

namespace Application.Zadanie
{
    public class ZadanieFactory : IZadanieFactory
    {
        public ZadanieFactory(IZadanieParser parser)
        {
            _parser = parser;
        }
        //public IZadanie CreateZadanie(ZadanieType zadanieType)
        //{
        //    IZadanie zadanie = null;
        //    switch (zadanieType)
        //    {
        //        case ZadanieType.Powtarzalne:
        //            zadanie = new ZadaniePowtarzalne();
        //            break;
        //        case ZadanieType.Single:
        //            zadanie = new ZadanieSingle();
        //            break;
        //        default:
        //            zadanie = new NullZadanie();
        //            break;
        //    }
        //    return zadanie;
        //}

        //public IZadanie CreateZadanie(ZadanieModel zadanieModel)
        //{
        //    IZadanie zadanie = CreateZadanie(zadanieModel.Type);
        //    zadanie.Parser(zadanieModel);

        //    return zadanie;
        //}

        public IZadanie Create(ZadanieModel zadanieModel)
        {
            IZadanie zadanie = new Domain.Entities.Zadanie();
            return _parser.Parse(zadanie,zadanieModel);
        }

        private readonly IZadanieParser _parser;
    }
}
