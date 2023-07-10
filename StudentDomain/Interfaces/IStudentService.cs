using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;

namespace StudentDomain.Interfaces
{
    public interface IStudentService
    {
        public Task<Student> AddStudent(StudentsResonse stuResponseObj);
        public void DeleteStudent(int id);
        public void UpdateStudent(int id, StudentsResonse stuResponseObj);
        public List<StudentsResonse> GetAllStudents();
        public Student GetStudentById(int id);
    }
}
