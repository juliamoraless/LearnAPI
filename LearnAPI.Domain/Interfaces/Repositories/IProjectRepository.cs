using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project?> GetProjectStudentsMentor(Guid id);
        Task<IEnumerable<Project>> GetProjectsByMentor(Guid mentorId);
        Task<IEnumerable<Project>> GetProjectsByClassroom(Guid classroomId);
    }
}
