using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Models
{
    public sealed class Project: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid MentorId { get; set; } 
        public Guid ClassroomId { get; set; }
        public List<Student> Students { get; set; } = null!;
        public Mentor Mentor { get; set; } = null!;
        public Classroom Classroom { get; set; } = null!;
    }
}
