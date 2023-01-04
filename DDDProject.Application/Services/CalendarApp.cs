using AutoMapper;
using DDDProject.Application.DTO;
using DDDProject.Application.Interfaces;
using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Services;

namespace DDDProject.Application.Services
{
    public class CalendarApp : ServiceAppBase<Calendar, CalendarDTO>, ICalendarApp
    {
        public CalendarApp(IMapper mapper, ICalendarService serviceBase) 
            : base(mapper, serviceBase)
        {
        }
    }
}
