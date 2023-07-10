using DataAccess.EFCore.Models;

namespace DataAccess.EFCore.Interfaces
{
    public interface StudentInterface
    {
        public Task<Student> Add(Student studentObj);

        public IEnumerable<Student> GetAll();
        public Student GetById(int id);
        public void Delete(Student studentObj);
        public void Update(Student studentObj);
    }
}
