using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnAPI.Application.Notificator;
using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Interfaces.Services;
using LearnAPI.Domain.Models;
using LearnAPI.Domain.Validations;

namespace LearnAPI.Application.Services
{
    public class ClassroomService : BaseService, IClassroomService
    {
        private readonly IClassroomRepository _classroomRepository;

        public ClassroomService(IClassroomRepository classroomRepository, INotificator notificator) : base(notificator)
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
