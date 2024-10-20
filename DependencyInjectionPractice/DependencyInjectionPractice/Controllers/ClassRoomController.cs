using DependencyInjectionPractice.Managers;
using DependencyInjectionPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ClassRoomController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult GetTeacherInfo()
        {
            // ClassRoom içerisindeki Teacher bilgisini döndürüyoruz
            _teacher.GetInfo();

            return Ok();
        }
    }


}
