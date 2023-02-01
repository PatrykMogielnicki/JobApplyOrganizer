using Application.JobService.Model;
using Domain.Entities.Interfaces;

namespace Application.JobService.Interface
{
    public interface IJobApplyParser
    {
        string Parse(IJobApply apply);
        IJobApply Parse(IJobApply apply, JobApplyModel model);
    }
}
