using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Interfaces.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student?> GetStudentClassroom(Guid id);
        Task<IEnumerable<Student>> GetStudentsByMentor(Guid mentorId);
    }
}
