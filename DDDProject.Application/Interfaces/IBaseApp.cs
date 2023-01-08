using DDDProject.Application.DTO;
using DDDProject.Domain.Entities;

namespace DDDProject.Application.Interfaces
{
    public interface IBaseApp<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO: BaseDTO
    {
        Task<int> AddAsync(TEntityDTO entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(TEntityDTO entity);
        Task<TEntityDTO> GetByIdAsync(int id);
        Task<IEnumerable<TEntityDTO>> GetAllAsync();
    }
}
