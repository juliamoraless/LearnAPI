using LearnAPI.Application.ViewModels.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Application.ViewModels.Project
{
    public class ProjectListViewModel
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IEnumerable<string> Students { get; set; } = null!;
        public string Mentor { get; set; } = null!;
        public string Classroom { get; set; } = null!;
    }
}
