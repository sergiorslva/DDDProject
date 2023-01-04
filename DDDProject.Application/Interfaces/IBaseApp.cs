using DDDProject.Application.DTO;
using DDDProject.Domain.Entities;

namespace DDDProject.Application.Interfaces
{
    public interface IBaseApp<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO: BaseDTO
    {
        Task Add(TEntityDTO entity);
        Task Delete(int id);
        Task Update(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
    }
}
