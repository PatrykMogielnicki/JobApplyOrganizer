using Application.JobService.Interface;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Application.JobService
{
    public class JobApplyRepository : IJobApplyRepository
    {
        public void Add(IJobApply apply)
        {
            if (!_list.Contains(apply))
            {
                _list.Add(apply);
            }
        }
        public void Update(IJobApply apply)
        {
            IJobApply zadanieToUpdate = new NullJobApply();
            _list.ForEach(zadanieL =>
            {
                if (zadanieL.Guid == apply.Guid)
                {
                    zadanieToUpdate = zadanieL;
                }
            });
            _list.Remove(zadanieToUpdate);
            _list.Add(apply);
        }
        public void Delete(IJobApply apply)
        {
            _list.Remove(apply);
        }
        public int Count => _list.Count;

        public List<IJobApply> GetList()
        {
            return _list;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IJobApply GetByName(string name)
        {
            foreach (IJobApply apply in _list)
            {
                if (apply.Name == name)
                {
                    return apply;
                }
            }
            return new NullJobApply();
        }

        private List<IJobApply> _list = new();
    }
}
