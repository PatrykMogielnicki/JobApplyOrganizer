namespace Domain.Entities.Interfaces
{
    public interface IJobApply
    {
        Guid Guid { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        Stage Stan { get; set; }
        string FileName { get; set; }
    }
}
