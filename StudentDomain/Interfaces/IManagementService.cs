using DataAccess.EFCore.Models;

namespace StudentDomain.Interfaces
{
    public interface IManagementService
    {
        public Task<Management> AddUser(Management managementObj);
        public IEnumerable<Management> GetUsers();
        public IEnumerable<Student> GetStudentsById(int id);
    }
}
