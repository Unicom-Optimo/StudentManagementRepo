using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using StudentDomain.Interfaces;

namespace StudentDomain.Services
{
    public class ManagementService : IManagementService
    {
        public readonly ManagementInterface _repository;

        public ManagementService(ManagementInterface repository)
        {
            _repository = repository;
        }

        public async Task<Management> AddUser(Management managementObj)
        {
            // throw new NotImplementedException();
            return await _repository.Add(managementObj);
        }

        public IEnumerable<Student> GetStudentsById(int id)
        {
            // throw new NotImplementedException();
            var manage = _repository.GetById(id);
            var students = manage.Students;
            List<Student> list = new List<Student>();


            if (students != null)
            {
                foreach (var item in students)
                {
                    Student std = new Student();
                    std.Id = item.Id;
                    std.Number = item.Number;
                    std.RegisterNo = item.RegisterNo;
                    std.FirstName = item.FirstName;
                    std.LastName = item.LastName;
                    std.Email = item.Email;
                    std.Dob = item.Dob;
                    std.Phone = item.Phone;
                    list.Add(std);
                }
            }
            return list;
        }

        public IEnumerable<Management> GetUsers()
        {
            // throw new NotImplementedException();
            return _repository.GetAll().ToList();
        }
    }
}
