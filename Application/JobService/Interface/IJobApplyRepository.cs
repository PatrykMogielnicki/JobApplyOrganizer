using Domain.Entities.Interfaces;

namespace Application.JobService.Interface
{
    public interface IJobApplyRepository
    {
        List<IJobApply> GetList();
        void Add(IJobApply apply);
        void Update(IJobApply apply);
        int Count { get; }
        void Clear();
        IJobApply GetByName(string name);

    }
}
