using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Models
{
    public sealed class Student: BaseEntity
    {
        public string Name { get; set; } = null!;
        public Guid ClassroomId { get; set; } 
        public Guid ProjectId { get; set; } 
        public Guid MentorId { get; set; }
        public Classroom Classroom { get; set; } = null!;
        public Project Project { get; set; } = null!;
        public Mentor Mentor { get; set; } = null!;


    }
}
