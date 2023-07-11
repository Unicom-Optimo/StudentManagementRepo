using DataAccess.EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using StudentDomain.Interfaces;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        public readonly IManagementService _managementService;

        public ManagementController(IManagementService managementService)
        {
            _managementService = managementService;
        }

        [HttpGet]
        public IEnumerable<Management> Get()
        {
            return _managementService.GetUsers().ToList();
        }


        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Student> GetStudentsById(int id)
        {
            return _managementService.GetStudentsById(id);

        }

    }
}
