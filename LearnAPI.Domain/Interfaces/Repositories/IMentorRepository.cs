using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Interfaces.Repositories
{
    public interface IMentorRepository : IRepository<Mentor>
    {
        Task<Mentor?> GetMentorStudents(Guid id);
        Task<IEnumerable<Mentor>> GetMentorsProjects();
    }
}
