using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;

namespace DDDProject.Infra.Data.Repositories
{
    public class CalendarRepository : BaseRepository<Calendar>, ICalendarRepository
    {
        public CalendarRepository(DDDPRojectContext dDDPRojectContext) : base(dDDPRojectContext)
        {
        }
    }
}
