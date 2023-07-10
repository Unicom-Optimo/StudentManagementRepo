using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repository
{
    public class CourseRepository : CourseInterface
    {
        public readonly StudentaManagementContext _studentaManagementContext;


        public readonly ILogger _logger;

        public CourseRepository(StudentaManagementContext studentaManagementContext)//ILogger<Course> logger, 
        {
            _studentaManagementContext = studentaManagementContext;
           // _logger = logger;
        }

        public async Task<Course> Add(Course courseObj)
        {
            //throw new NotImplementedException();
            try
            {
                if (courseObj != null)
                {
                    var obj = _studentaManagementContext.Add<Course>(courseObj);
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
                throw e;
            }




        }

        public IEnumerable<Course> GetAll()
        {
            //throw new NotImplementedException();
            try
            {
                var obj = _studentaManagementContext.Course.Include(a => a.Management).ToList();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public IEnumerable<Course> GetById(int id)
        {
            //throw new NotImplementedException();
            try
            {
                if (id != null)
                {
                    var obj = _studentaManagementContext.Managements.Include(data => data.Courses).
                        FirstOrDefault(a => a.ManageId == id);
                    if (obj != null)
                        return obj.Courses;
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
    
    
}
