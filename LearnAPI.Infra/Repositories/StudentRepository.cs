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
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(LearnContext context) : base(context)
        {

        }
        public async Task<Student?> GetStudentClassroom(Guid id)
        {
            return await _context.Students
                .AsNoTracking()
                .Include(s => s.Classroom)
                    .ThenInclude(c => c.Name)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Student>> GetStudentsByMentor(Guid mentorId)
        {
            return await Search(s => s.MentorId == mentorId);
        }
    }
}
