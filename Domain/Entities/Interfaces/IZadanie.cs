namespace Domain.Entities.Interfaces
{
    public interface IZadanie
    {
        Guid Guid { get; set; }
        int Checked { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        Color Color { get; set; }
        List<DateTime> Date { get; set; }
        PriorityLevel Priority { get; set; }
        Stage Stan { get; set; }
        string FileName { get; set; }
    }
}
