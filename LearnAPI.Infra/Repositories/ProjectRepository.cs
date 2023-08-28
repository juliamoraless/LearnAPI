using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Infra.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(LearnContext context) : base(context)
        {
        }

        public async Task<Project?> GetProjectStudentsMentor(Guid id)
        {
            return await _context.Projects
                .AsNoTracking()
                .Include(p => p.Students)
                    .ThenInclude(s => s.Name)
                .Include(p => p.Mentor)
                    .ThenInclude(m => m.Name)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Project>> GetProjectsByClassroom(Guid classroomId)
        {
            return await Search(p => p.ClassroomId == classroomId);
        }

        public async Task<IEnumerable<Project>> GetProjectsByMentor(Guid mentorId)
        {
            return await Search(p => p.MentorId == mentorId);
        }
    }
}
