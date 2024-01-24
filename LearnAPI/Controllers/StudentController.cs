using LearnAPI.Application.ViewModels.Student;
using LearnAPI.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class StudentController : ControllerBase
    {
        //Validacao de notificacoes de erro
        //Validacao de modelstate (preenchimento correto das viewmodels)
        //Validacao de operação de negocios

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        [HttpGet("students-list")]
        public async Task<IEnumerable<StudentListViewModel>> GetAll()
        {
           return await _studentService.GetStudents();
        } 
        
    }
}
