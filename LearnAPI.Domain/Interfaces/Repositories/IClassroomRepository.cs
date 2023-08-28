using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Interfaces.Repositories
{
    public interface IClassroomRepository : IRepository<Classroom>
    {
        Task<Classroom?> GetClassroomWithStudents(Guid id);
    }
}
