using AutoMapper;
using DDDProject.Application.DTO;
using DDDProject.Domain.Entities;

namespace DDDProject.Application.Mapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<Calendar, CalendarDTO>();
            CreateMap<CalendarDTO, Calendar>();
        }
    }
}
