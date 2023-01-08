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

        public async Task<int> AddAsync(TEntity entity)
        {
            return await _baseRepository.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            return await _baseRepository.UpdateAsync(entity);
        }
    }
}
