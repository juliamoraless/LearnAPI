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
    public class MentorRepository : Repository<Mentor>, IMentorRepository
    {
        public MentorRepository(LearnContext context) : base(context)
        {
            
        }

        public async Task<Mentor?> GetMentorStudents(Guid id)
        {
           return await _context.Mentors
                .AsNoTracking()
                .Include(m => m.Students)
                    .ThenInclude(s => s.Name)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        //TO DO: Ver como incluir dois campos de projects
        public async Task<IEnumerable<Mentor>> GetMentorsProjects()
        {
            return await _context.Mentors
                .AsNoTracking()
                .Include(m => m.Projects)
                    .ThenInclude(s => s.Name)
                .ToListAsync();
                   
        }
    }
}
