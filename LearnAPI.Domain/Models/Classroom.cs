using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Models
{
    public sealed class Classroom : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Turno { get; set; } = null!;
        public List<Student> Students { get; set; } = null!;
        public List<Project> Projects { get; set; } = null!;
        public List<Mentor> Mentors { get; set; } = null!;
    }
}
