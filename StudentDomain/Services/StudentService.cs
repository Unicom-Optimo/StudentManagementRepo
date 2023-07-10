using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using StudentDomain.Interfaces;

namespace StudentDomain.Services
{
    public class StudentService : IStudentService
    {

        public readonly StudentInterface _repository;
        private IEnumerable<StudentsResonse> responses;

        public StudentService(StudentInterface repository)
        {
            _repository = repository;
        }

        public async Task<Student> AddStudent(StudentsResonse stuResponseObj)
        {
            //throw new NotImplementedException();
           
                Student student = new Student();
                student.Id = stuResponseObj.Id;
                student.Number = stuResponseObj.Number;
                student.FirstName = stuResponseObj.FirstName;
                student.LastName = stuResponseObj.LastName;
                student.Email = stuResponseObj.Email;
                student.Dob = stuResponseObj.Dob;
                student.Phone = stuResponseObj.Phone;

                return await _repository.Add(student);
            
            
        }

        public async void DeleteStudent(int id)
        {
            //throw new NotImplementedException();
            var obj = _repository.GetById(id);
            _repository.Delete(obj);
        }

        public List<StudentsResonse> GetAllStudents()
        {
            //throw new NotImplementedException();
            var student = _repository.GetAll().ToList();
            List<StudentsResonse> list = new List<StudentsResonse>();

            if (student != null)
            {
                foreach (var user in student)
                {
                    var res = new StudentsResonse();
                    res.Id = user.Id;
                    res.Number = user.Number;
                    res.RegisterNo = user.RegisterNo;
                    res.FirstName = user.FirstName;
                    res.LastName = user.LastName;
                    res.Email = user.Email;
                    res.Dob = user.Dob;
                    res.Phone = user.Phone;
                    res.ManageId = user.ManagementId;
                    res.ManageName = user.Management.ManageName;


                    list.Add(res);
                }
            }
            return list;
        }

        public Student GetStudentById(int id)
        {
            //throw new NotImplementedException();

            return _repository.GetById(id);
        }

        public void UpdateStudent(int id, StudentsResonse stuResponseObj)
        {
            //throw new NotImplementedException();
            if (id != 0 && stuResponseObj != null)
            {
                Student obj = _repository.GetById(id);
                obj.Number = stuResponseObj.Number;
                obj.RegisterNo = stuResponseObj.RegisterNo;
                obj.FirstName = stuResponseObj.FirstName;
                obj.LastName = stuResponseObj.LastName;
                obj.Email = stuResponseObj.Email;
                obj.Dob = stuResponseObj.Dob;
                obj.Phone = stuResponseObj.Phone;


                if (obj != null)
                    _repository.Update(obj);
            }

        }
    }
}

