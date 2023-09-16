using LearnAPI.Application.ViewModels.Mentor;
using LearnAPI.Application.ViewModels.Project;
using LearnAPI.Application.ViewModels.Student;


namespace LearnAPI.Application.ViewModels.Classroom
{
    public class ClassroomListViewModel
    {
        public string Name { get; set; } = null!;
        public string Turno { get; set; } = null!;
        public IEnumerable<string> Students { get; set; } = null!;
        public IEnumerable<ProjectSimpleViewModel> Projects { get; set; } = null!;
        public IEnumerable<string> Mentors { get; set; } = null!;
    }
}
