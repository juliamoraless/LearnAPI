using LearnAPI.Application.ViewModels.Student;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentListViewModel>>> GetAll()
        {


            return Ok();
        } 
        
    }
}
