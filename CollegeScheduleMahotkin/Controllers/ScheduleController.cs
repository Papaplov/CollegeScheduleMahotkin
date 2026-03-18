using CollegeScheduleMahotkin.Data;
using CollegeScheduleMahotkin.Models;
using CollegeScheduleMahotkin.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeScheduleMahotkin.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController
    {
        private readonly IScheduleService _service;
        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _service = service;
        }
    }
}
