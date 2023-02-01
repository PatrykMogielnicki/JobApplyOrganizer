using Application.JobService.Interface;
using Application.JobService.Model;
using Domain.Entities.Interfaces;

namespace Application.JobService
{
    public class JobApplyService : IJobApplyService
    {
        public JobApplyService(IJobApplyFactory Factory, IJobApplyRepository Repository, IJobApplySave Save, IJobApplyLoad Load)
        {
            //TODO move _name to config file
            _name = "lista_cv";
            _factory = Factory;
            _repository = Repository;
            _save = Save;
            _load = Load;
        }
        public void Create(JobApplyModel model)
        {
            _repository.Add(
                _factory.Create(model)
            );
        }

        public void Update(IJobApply apply)
        {
            _repository.Update(apply);
        }

        public List<IJobApply> GetAll()
        {
            return _repository.GetList();
        }

        public void Save()
        {
            _save.Save(_name, _repository);
        }

        public void Load()
        {
            _load.Load(_name, _repository);
        }

        private string _name;
        private readonly IJobApplyFactory _factory; // singleton
        private readonly IJobApplyRepository _repository;
        private readonly IJobApplyLoad _load; // singleton
        private readonly IJobApplySave _save; // singleton
    }
}
