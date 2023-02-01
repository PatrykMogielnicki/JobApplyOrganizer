namespace Application.JobService.Interface
{
    public interface IJobApplyLoad
    {
        void Load(string name, IJobApplyRepository repository);
    }
}
