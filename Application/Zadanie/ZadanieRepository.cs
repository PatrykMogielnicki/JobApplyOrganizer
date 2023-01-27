using Application.Zadanie.Interface;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Application.Zadanie
{
    public class ZadanieRepository : IZadanieRepository
    {
        public void Add(IZadanie zadanie)
        {
            if (!Lista.Contains(zadanie))
            {
                Lista.Add(zadanie);
            }
        }
        public void Update(IZadanie zadanie)
        {
            IZadanie zadanieToUpdate = new NullZadanie();
            Lista.ForEach(zadanieL =>
            {
                if (zadanieL.Guid == zadanie.Guid)
                {
                    zadanieToUpdate = zadanieL;
                }
            });
            Lista.Remove(zadanieToUpdate);
            Lista.Add(zadanie);
        }
        public void Delete(IZadanie zadanie)
        {
            Lista.Remove(zadanie);
        }
        public int Count => Lista.Count;

        public List<IZadanie> GetList()
        {
            return Lista;
        }

        public void Clear()
        {
            Lista.Clear();
        }

        public IZadanie GetByName(string name)
        {
            foreach (var zadanie in Lista)
            {
                if (zadanie.Name == name)
                {
                    return zadanie;
                }
            }
            return new NullZadanie();
        }

        private List<IZadanie> Lista = new();
    }
}
