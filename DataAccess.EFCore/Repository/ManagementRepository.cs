using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repository
{
    public class ManagementRepository : ManagementInterface
    {


        public readonly StudentaManagementContext _studentaManagementContext;


        public readonly ILogger _logger;

        public ManagementRepository(ILogger<Course> logger, StudentaManagementContext studentaManagementContext)
        {
            _studentaManagementContext = studentaManagementContext;
            _logger = logger;
        }



        public async Task<Management> Add(Management managementObj)
        {
            // throw new NotImplementedException();
            try
            {
                if (managementObj != null)
                {
                    var obj = _studentaManagementContext.Add<Management>(managementObj);
                    await _studentaManagementContext.SaveChangesAsync();
                    return obj.Entity;
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

        public IEnumerable<Management> GetAll()
        {
            // throw new NotImplementedException();
            try
            {
                var obj = _studentaManagementContext.Managements
                    .Include(data => data.Students)
                    .Include(data => data.Courses)
                    .ToList();
                if (obj != null)
                    return obj;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Management GetById(int id)
        {
            //throw new NotImplementedException();
            try
            {
                if (id != null)
                {
                    var obj = _studentaManagementContext.Managements
                        .Include(data => data.Students)
                        .FirstOrDefault(a => a.ManageId == id);
                    if (obj != null) return obj;
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception) { throw; }
        }
    }
    
  }

