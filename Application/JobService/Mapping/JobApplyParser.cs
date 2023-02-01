using Application.Common;
using Application.JobService.Interface;
using Application.JobService.Model;
using Domain.Entities.Interfaces;

namespace Application.JobService.Mapping
{
    public class JobApplyParser : IJobApplyParser
    {
        public string Parse(IJobApply apply)
        {
            return string.Format(
                "{0},{1},{2},{3},{4},{5}",
                apply.Guid,
                apply.Name,
                (int)apply.Stan,
                apply.FileName,
                apply.Date,
                Base64Parser.Encode(apply.Description)
            );
        }

        public IJobApply Parse(IJobApply apply, JobApplyModel model)
        {
            apply.Name = model.Name;
            apply.Date = model.Date;
            apply.Description = model.Description;
            apply.Stan = model.Stan;
            apply.FileName = model.FileLink;
            return apply;
        }
    }
}
