using LearnAPI.Application.Notificator;
using LearnAPI.Application.Services;
using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Domain.Interfaces.Services;
using LearnAPI.Infra.Repositories;

namespace LearnAPI.Configuration
{
    public static class InjecaoDP
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<IMentorRepository, MentorRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClassroomService, ClassroomService>();

            services.AddScoped<INotificator, Notificator>();
            
        }

    }
}
