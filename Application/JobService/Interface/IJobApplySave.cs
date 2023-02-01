namespace Application.JobService.Interface
{
    public interface IJobApplySave
    {
        void Save(string name, IJobApplyRepository repository);
    }
}
