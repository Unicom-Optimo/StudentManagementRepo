using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using StudentDomain.Interfaces;

namespace StudentDomain.Services
{
    public class CourseService : ICourseService
    {

        public readonly CourseInterface _repository;

        private IEnumerable<Course> _courses;

        public CourseService(CourseInterface repository)
        {
            _repository = repository;
        }


        public async Task<Course> AddCourses(CourseResponse courResponseObj)
        {
            //throw new NotImplementedException();
            Course course = new Course();
            course.Id = courResponseObj.Id;
            course.Number = courResponseObj.Number;
            course.Name = courResponseObj.Name;
            course.Duration = courResponseObj.Duration;
            course.Fees = courResponseObj.Fees;
            //course.ManagementId = courResponseObj.ManageId;
            return await _repository.Add(course);

        }

        public List<CourseResponse> GetAllCourse()
        {
            // throw new NotImplementedException();
            var courses = _repository.GetAll().ToList();
            List<CourseResponse> list = new List<CourseResponse>();

            if (courses != null)
            {
                foreach (var course in courses)
                {
                    var res = new CourseResponse();
                    res.Id = course.Id;
                    res.Number = course.Number;
                    res.Name = course.Name;
                    res.Duration = course.Duration;
                    res.Fees = course.Fees;
                    res.ManageId = course.ManagementId.Value;
              

                    list.Add(res);
                }
            }
            return list;

        }

        public IEnumerable<Course> GetCourseById(int id)
        {
            //throw new NotImplementedException();
            var course = _repository.GetById(id);
            List<Course> list = new List<Course>();

            if (course != null)
            {
                foreach (var c in course)
                {
                    Course res = new Course();
                    res.Id = c.Id;
                    res.Name = c.Name;
                    list.Add(res);
                }
            }
            return list;
        }

        public IEnumerable<Course> GetStudentsById(int id)
        {
            throw new NotImplementedException();

        }
    }
}
