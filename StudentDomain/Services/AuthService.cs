using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using StudentDomain.Interfaces;

namespace StudentDomain.Services
{
    public class AuthService : IAuthService
    {
        private readonly AuthInterface _repository;

        private IEnumerable<User> _res;


        public AuthService(AuthInterface repository)
        {
            _repository= repository;
        }

        public async Task<User> AddUsers(User _object)
        {
            //throw new NotImplementedException();
            return await _repository.Create(_object);

        }

        public Task<User> UserAuthenticat(AuthResponse _object)
        {
            //throw new NotImplementedException();
            User user = new User();
            if (user != null)
            {
                user.UserName =_object.UserName;
                user.Password = _object.Password;
            }
            return _repository.Authenticate(user);  
        }
    }
}
