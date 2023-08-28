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
    public class ClassroomRepository : Repository<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(LearnContext context) : base(context)
        {

        }
        public async Task<Classroom?> GetClassroomWithStudents(Guid id)
        {
            return await _context.Classrooms
                .AsNoTracking()
                .Include(c => c.Students)
                    .ThenInclude(s => s.Name)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
