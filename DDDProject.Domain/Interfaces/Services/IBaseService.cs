using DDDProject.Domain.Entities;

namespace DDDProject.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity 
    {
        Task<int> AddAsync(TEntity entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
