using AutoMapper;
using DDDProject.Application.DTO;
using DDDProject.Application.Interfaces;
using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Services;

namespace DDDProject.Application.Services
{
    public class ServiceAppBase<TEntity, TEntityDTO> : IBaseApp<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        private readonly IMapper _mapper;
        private readonly IBaseService<TEntity> _serviceBase;

        public ServiceAppBase(IMapper mapper, IBaseService<TEntity> serviceBase)
        {
            _mapper = mapper;
            _serviceBase = serviceBase;
        }
        public async Task<int> AddAsync(TEntityDTO entity)
        {
            return await _serviceBase.AddAsync(_mapper.Map<TEntity>(entity));
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _serviceBase.DeleteAsync(id);
        }

        public async Task<IEnumerable<TEntityDTO>> GetAllAsync()
        {
            var res = await _serviceBase.GetAllAsync();
            return _mapper.Map<IEnumerable<TEntityDTO>>(res);            
        }

        public async Task<TEntityDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<TEntityDTO>(await _serviceBase.GetByIdAsync(id));
        }

        public async Task<int> UpdateAsync(TEntityDTO entity)
        {
            return await _serviceBase.UpdateAsync(_mapper.Map<TEntity>(entity));
        }
    }
}
