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

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CalendarDTO calendarDTO)
        {
            return Ok(await _calendarApp.AddAsync(calendarDTO));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromForm] CalendarDTO calendarDTO)
        {
            return Ok(await _calendarApp.UpdateAsync(calendarDTO));
        }

        [HttpDelete]
        [Route("id")]
        public async Task<IActionResult> Put([FromQuery] int id)
        {
            return Ok(await _calendarApp.DeleteAsync(id));
        }

        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            return Ok(await _calendarApp.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _calendarApp.GetAllAsync());
        }
    }
}