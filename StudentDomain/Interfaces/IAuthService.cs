using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;

namespace StudentDomain.Interfaces
{
    public interface IAuthService
    {
        public Task<User> AddUsers(User _object);

        public Task<User> UserAuthenticat(AuthResponse _object);
    }
}
