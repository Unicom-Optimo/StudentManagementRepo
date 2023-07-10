using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;

namespace StudentDomain.Interfaces
{
    public interface ICourseService
    {
        public Task<Course> AddCourses(CourseResponse courResponseObj);
        public List<CourseResponse> GetAllCourse();
        public IEnumerable<Course> GetCourseById(int id);
        IEnumerable<Course> GetStudentsById(int id);
    }
}
