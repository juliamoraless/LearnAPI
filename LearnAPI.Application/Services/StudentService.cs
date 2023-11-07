
using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Interfaces.Services;
using LearnAPI.Domain.Models;
using LearnAPI.Domain.Validations;

namespace LearnAPI.Application.Services
{
    public class StudentService : Service, IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task Get()
        {
            throw new NotImplementedException();
        }
        public async Task Post(Student student)
        {
            if (!ExecuteValidation(new StudentValidation(), student)) return;

            if (_studentRepository.Search(s => s.Document == student.Document).Result.Any())
            {
                Notificate("Já existe um aluno com este documento informado");
                return;
            }

            await _studentRepository.Create(student);
        }
        
        public async Task Update(Student student)
        {
            if (!ExecuteValidation(new StudentValidation(), student)) return;

            if (_studentRepository.Search(s => s.Id == student.Id).Result.Equals(null))
            {
                Notificate("Não existe um aluno com o Id informado");
                return;
            }

            await _studentRepository.Update(student);
        }
        
        public async Task Remove(Guid id)
        {
            //var student = _studentRepository.GetById(id);
            //if (student == null) 
            //{
            //    Notificate("Não existe um aluno com o Id informado");
            //    return;
            //}

            //await _studentRepository.Delete(student);
        }
        
        public void Dispose() {
            _studentRepository?.Dispose();
        }
    }
}
