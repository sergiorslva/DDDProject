using DDDProject.Application.DTO;
using DDDProject.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDDProject.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarApp _calendarApp;
        private readonly ILogger<CalendarController> _logger;

        public CalendarController(ICalendarApp calendarApp, ILogger<CalendarController> logger)
        {
            _calendarApp = calendarApp;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CalendarDTO> Get()
        {
            return _calendarApp.GetAll();
        }
    }
}