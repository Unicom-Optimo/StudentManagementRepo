using DataAccess.EFCore.Models;

namespace DataAccess.EFCore.Interfaces
{
    public interface AuthInterface
    {
        public Task<User> Create(User userObj);
        public Task<User> Authenticate(User userObj);
    }
}
