using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repository
{
    public class StudentRepository : StudentInterface

    {

        public readonly StudentaManagementContext _studentaManagementContext;


        public readonly ILogger _logger;

        public StudentRepository(ILogger<Course> logger, StudentaManagementContext studentaManagementContext)
        {
            _studentaManagementContext = studentaManagementContext;
            _logger = logger;
        }


        public async Task<Student> Add(Student studentObj)
        {
            // throw new NotImplementedException();
            try
            {
                if (studentObj != null)
                {
                    var obj = _studentaManagementContext.Add<Student>(studentObj);
                    await _studentaManagementContext.SaveChangesAsync();
                    return obj.Entity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw;

            }

        }

        public void Delete(Student studentObj)
        {
            //throw new NotImplementedException();
            try
            {
                if (_studentaManagementContext != null)
                {
                    var obj = _studentaManagementContext.Remove(studentObj);
                    if (obj != null)
                    {
                        _studentaManagementContext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public IEnumerable<Student> GetAll()
        {
            // throw new NotImplementedException();
            try
            {
                var obj = _studentaManagementContext.Student.Include(a => a.Management).ToList();
                if (obj != null)
                {
                    return obj;
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Student GetById(int id)
        {
            //throw new NotImplementedException();
            try
            {
                if (id != null)
                {
                    var obj = _studentaManagementContext.Student.FirstOrDefault(x => x.Id == id);
                    if (obj != null)
                        return obj;
                    else
                        return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Student studentObj)
        {
            //throw new NotImplementedException();
            try
            {
                if (studentObj != null)
                {
                    var obj = _studentaManagementContext.Update(studentObj);
                    if (obj != null)
                        _studentaManagementContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    
    }

