using Application.JobService.Model;
using Domain.Entities.Interfaces;

namespace Application.JobService.Interface
{
    public interface IJobApplyFactory
    {
        IJobApply Create(JobApplyModel jobApplyModel);
    }
}
