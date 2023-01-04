using DDDProject.Domain.Entities;

namespace DDDProject.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity 
    {
        Task Add(TEntity entity);
        Task Delete(int id);
        Task Update(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
