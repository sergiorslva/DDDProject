using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;

namespace DDDProject.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly DDDPRojectContext _dDDPRojectContext;

        public BaseRepository(DDDPRojectContext dDDPRojectContext)
        {
            _dDDPRojectContext = dDDPRojectContext;
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            _dDDPRojectContext.Set<TEntity>().Add(entity);
            return await _dDDPRojectContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = _dDDPRojectContext.Set<TEntity>().Find(id);

            if(entity != null)
            {
                _dDDPRojectContext.Set<TEntity>().Remove(entity);
                return await _dDDPRojectContext.SaveChangesAsync();
            }            

            return await Task.FromResult(0);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entities = _dDDPRojectContext.Set<TEntity>().ToList();
            return await Task.FromResult(entities);

        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dDDPRojectContext.Set<TEntity>().FindAsync(id);            
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            _dDDPRojectContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return await _dDDPRojectContext.SaveChangesAsync();
        }
    }
}
