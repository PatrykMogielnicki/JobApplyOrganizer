using Domain.Entities.Interfaces;
using Domain.Entities;
using Application.JobService.Interface;
using Application.JobService.Model;

namespace Application.JobService
{
    public class JobApplyFactory : IJobApplyFactory
    {
        public JobApplyFactory(IJobApplyParser parser)
        {
            _parser = parser;
        }

        public IJobApply Create(JobApplyModel model)
        {
            IJobApply apply = new JobApply();
            return _parser.Parse(apply, model);
        }

        private readonly IJobApplyParser _parser;
    }
}
