using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using Microsoft.AspNetCore.Mvc;
using StudentDomain.Interfaces;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/v{VersionId}/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService=authService;
        }


        [HttpPost]
        [Route("Authenticate")]
        public async Task<bool> Authenticate([FromBody] AuthResponse authResponseObj)
        {
            if(authResponseObj == null) 
            { 
            return false;
            }

            var user = _authService.UserAuthenticat(authResponseObj);
            if (user.Result == null)
            {
                return false;
            }
            return true;
        }



        [HttpPost]
        [Route("register")]
        public async Task<User> register([FromBody] User userObj)
        {
            return await _authService.AddUsers(userObj);
        }
    
    
    
    }





}
