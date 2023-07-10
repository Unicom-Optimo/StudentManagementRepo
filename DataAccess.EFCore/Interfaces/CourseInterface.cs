using DataAccess.EFCore.Models;

namespace DataAccess.EFCore.Interfaces
{
    public interface CourseInterface
    {
        public Task<Course> Add(Course courseObj);
        public IEnumerable<Course> GetAll();
        public IEnumerable<Course> GetById(int id);
    }
}
