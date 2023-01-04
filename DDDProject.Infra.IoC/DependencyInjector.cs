using DDDProject.Application.Interfaces;
using DDDProject.Application.Services;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;
using DDDProject.Domain.Services;
using DDDProject.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DDDProject.Infra.IoC
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IBaseApp<,>), typeof(ServiceAppBase<,>));
            serviceCollection.AddScoped<ICalendarApp, CalendarApp>();

            serviceCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            serviceCollection.AddScoped<ICalendarService, CalendarService>();

            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<ICalendarRepository, CalendarRepository>();
        }
    }
}
