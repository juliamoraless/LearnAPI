
using LearnAPI.Domain.Interfaces.Services;
using LearnAPI.Domain.Models;
using LearnAPI.Domain.Validations;

namespace LearnAPI.Application.Services
{
    public class StudentService : Service, IStudentService
    {
        public Task Listar()
        {
            throw new NotImplementedException();
        }
        public async Task Add(Student student)
        {
            //Validar o estado da entidade
            //Se nao existe aluno com o mesmo documento
            if (!ExecuteValidation(new StudentValidation(), student)) return;

            return;
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
