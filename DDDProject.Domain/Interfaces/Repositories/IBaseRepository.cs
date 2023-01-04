using DDDProject.Domain.Entities;

namespace DDDProject.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        Task Delete(int id);
        Task Update(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
