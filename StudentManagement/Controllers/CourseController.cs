using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using Microsoft.AspNetCore.Mvc;
using StudentDomain.Interfaces;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public readonly ICourseService _courseService;


        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpGet]
        public IEnumerable<CourseResponse> Get()
        {
            return _courseService.GetAllCourse().ToList();
        }

        [HttpPost]
        public async Task<Course> Add(CourseResponse courseResponse)
        {
            return await _courseService.AddCourses(courseResponse);
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Course> GetCourseById(int id)
        {
            return _courseService.GetCourseById(id);
        }


    }
}
