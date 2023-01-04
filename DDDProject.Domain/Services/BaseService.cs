using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;

namespace DDDProject.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Task Add(TEntity entity)
        {
            return _baseRepository.Add(entity);
        }

        public Task Delete(int id)
        {
            return _baseRepository.Delete(id);
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public Task<TEntity> GetById(int id)
        {
            return _baseRepository.GetById(id);
        }

        public Task Update(TEntity entity)
        {
            return _baseRepository.Update(entity);
        }
    }
}
