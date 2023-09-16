using LearnAPI.Application.ViewModels.Project;
using LearnAPI.Application.ViewModels.Student;

namespace LearnAPI.Application.ViewModels.Mentor
{
    public class MentorListViewModel
    {
        public string Name { get; set; } = null!;
        public IEnumerable<ProjectSimpleViewModel> Projects { get; set; } = null!;
        public IEnumerable<string> Students { get; set; } = null!;
        public string Classroom { get; set; } = null!;
    }
}
