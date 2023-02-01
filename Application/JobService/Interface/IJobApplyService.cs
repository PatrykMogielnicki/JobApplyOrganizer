using Application.JobService.Model;
using Domain.Entities.Interfaces;

namespace Application.JobService.Interface
{
    public interface IJobApplyService
    {
        void Create(JobApplyModel model);
        void Update(IJobApply apply);
        List<IJobApply> GetAll();
        void Load();
        void Save();
    }
}
