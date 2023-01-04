using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;

namespace DDDProject.Domain.Services
{
    public class CalendarService : BaseService<Calendar>, ICalendarService
    {
        public CalendarService(IBaseRepository<Calendar> baseRepository) : base(baseRepository)
        {
        }
    }
}
