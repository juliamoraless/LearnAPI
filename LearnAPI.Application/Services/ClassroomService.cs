using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Interfaces.Services;
using LearnAPI.Domain.Models;
using LearnAPI.Domain.Validations;

namespace LearnAPI.Application.Services
{
    public class ClassroomService : Service, IClassroomService
    {
        private readonly IClassroomRepository _classroomRepository;

        public ClassroomService(IClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }
        public Task Get()
        {
            throw new NotImplementedException();
        }

        public async Task Post(Classroom classroom)
        {
            if (!ExecuteValidation(new ClassroomValidation(), classroom)) return;

            await _classroomRepository.Create(classroom);
        }

        public async Task Update(Classroom classroom)
        {
            if (!ExecuteValidation(new ClassroomValidation(), classroom)) return;

            await _classroomRepository.Create(classroom);
        }

        public async Task Remove(Guid id)
        {
         //   await _classroomRepository.Delete();
        }
        public void Dispose()
        {
            _classroomRepository?.Dispose();
        }
    }
}
