namespace Domain.Entities
{
    public class JobApply : IJobApply
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Stage Stan { get; set; }
        public string FileName { get; set; }
    }
}
