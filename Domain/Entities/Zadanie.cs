namespace Domain.Entities
{
    public class Zadanie : IZadanie
    {
        public Guid Guid { get; set; }
        public int Checked { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Color Color { get; set; }
        public List<DateTime> Date { get; set; }
        public PriorityLevel Priority { get; set; }
        public Stage Stan { get; set; }
        public string FileName { get; set; }
    }
}
