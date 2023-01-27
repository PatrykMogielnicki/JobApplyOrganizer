using Domain.Enums;
using Domain.ValueObjects;

namespace Application.Zadanie.Model
{
    public class ZadanieModel
    {
        public Guid Id;
        public int Checked;
        public string Name;
        public string Description = "";
        public Color Color;
        public List<DateTime> Date = new List<DateTime>();
        public Stage Stan = Stage.Wyslane_CV;
        public string FileLink;
    }
}
