using Domain.Enums;

namespace Application.JobService.Model
{
    public class JobApplyModel
    {
        public Guid Id;
        public string Name;
        public string Description = "";
        public DateTime Date = new DateTime();
        public Stage Stan = Stage.Wyslane_CV;
        public string FileLink;
    }
}
