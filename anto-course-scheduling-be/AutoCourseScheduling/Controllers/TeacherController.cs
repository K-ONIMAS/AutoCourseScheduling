using AutoCourseScheduling.Models;
using AutoCourseScheduling.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoCourseScheduling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
       

        private readonly ILogger<TeacherController> _logger;
        private readonly DBContext _dBContext;

        public TeacherController(ILogger<TeacherController> logger,DBContext context)
        {
            _logger = logger;
            _dBContext = context;
            
        }

 
    }
}