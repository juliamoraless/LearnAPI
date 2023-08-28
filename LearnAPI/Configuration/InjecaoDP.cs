using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Infra.Repositories;

namespace LearnAPI.Configuration
{
    public static class InjecaoDP
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IClassroomRepository, ClassroomRepository>();
            services.AddTransient<IMentorRepository, MentorRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
        }

    }
}
