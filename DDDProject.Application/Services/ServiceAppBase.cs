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
        public Task Add(TEntityDTO entity)
        {
            return _serviceBase.Add(_mapper.Map<TEntity>(entity));
        }

        public Task Delete(int id)
        {
            return _serviceBase.Delete(id);
        }

        public IEnumerable<TEntityDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<TEntityDTO>>(_serviceBase.GetAll());            
        }

        public TEntityDTO GetById(int id)
        {
            return _mapper.Map<TEntityDTO>(_serviceBase.GetById(id));
        }

        public Task Update(TEntityDTO entity)
        {
            return _serviceBase.Update(_mapper.Map<TEntity>(entity));
        }
    }
}
