using CollegeScheduleMahotkin.Data;
using CollegeScheduleMahotkin.Models;
using CollegeScheduleMahotkin.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeScheduleMahotkin.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;
        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _service = service;
        }

        // GET: api/schedule/group/{groupId}?start=2026-03-16&end=2026-04-15
        [HttpGet("group/{groupId}")]
        public async Task<IActionResult> GetSchedule(string groupName, DateTime start, DateTime end)
        {
            // Вызываем бизнес-логику из сервиса
            var result = await _service.GetScheduleForGroup(groupName, start.Date, end.Date);
            // Возвращаем результат со статусом 200 OK
            return Ok(result);
        }
    }
}
