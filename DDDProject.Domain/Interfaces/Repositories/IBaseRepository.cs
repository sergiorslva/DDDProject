using DDDProject.Domain.Entities;

namespace DDDProject.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<int> AddAsync(TEntity entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
