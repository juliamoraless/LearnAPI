using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Models
{
    public sealed class Mentor: BaseEntity
    {
        public string Name { get; set; } = null!;
        public Guid ClassroomId { get; set; }
        public List<Project> Projects { get; set; } = null!;
        public List<Student> Students { get; set; } = null!;
        public Classroom Classroom { get; set; } = null!;
    }
}
