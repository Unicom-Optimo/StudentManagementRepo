using DataAccess.EFCore.Models;
using DataAccess.EFCore.Response;
using Microsoft.AspNetCore.Mvc;
using StudentDomain.Interfaces;

namespace StudentManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentManagementController : ControllerBase
    {
        public readonly IStudentService _studentService;
        public readonly IManagementService _managementService;

        public StudentManagementController(IStudentService studentService, IManagementService managementService)
        {
            _studentService = studentService;
            _managementService = managementService;
        }

        [HttpGet]
        public IEnumerable<StudentsResonse> Get()
        {
            return _studentService.GetAllStudents().ToList();
        }

        [HttpGet]
        [Route("GetManagements")]
        public IEnumerable<Management> GetManagements()
        {
            return _managementService.GetUsers().ToList();
        }

        [HttpPost]
        public async Task<Student> Add(StudentsResonse addStudentRequest)
        {
            return await _studentService.AddStudent(addStudentRequest);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Student> GetStudentById([FromRoute] int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPut]
        [Route("{id}")]
        public void Update([FromRoute] int id, StudentsResonse updateStudentRequest)
        {
            _studentService.UpdateStudent(id, updateStudentRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public async void DeleterRequest([FromRoute] int id)
        {
            _studentService.DeleteStudent(id);
        }


    }
}

