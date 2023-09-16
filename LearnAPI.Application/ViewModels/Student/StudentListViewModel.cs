using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Application.ViewModels.Student
{
    public sealed class StudentListViewModel
    {
        public string Name { get; set; } = null!;
        public string Classroom { get; set; } = null!;
        public string Project { get; set; } = null!;
        public string Mentor { get; set; } = null!;

    }
}
