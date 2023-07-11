using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repository
{
    public class AuthRepository : AuthInterface
    {
        private readonly StudentaManagementContext _context;



        public AuthRepository(StudentaManagementContext context)
        {
            _context=context;
        }

        public async Task<User> Authenticate(User userObj)
        {
            // throw new NotImplementedException();
            try
            {
                if(userObj != null)
                {
                    var obj = _context.Add<User>(userObj);
                    await _context.SaveChangesAsync();
                    return obj.Entity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<User> Create(User userObj)
        {
            //throw new NotImplementedException();
            var user = await _context.Users.FirstOrDefaultAsync(a => a.UserName == userObj.UserName
            && a.Password == userObj.Password);
            return user;
        }
    }
}
