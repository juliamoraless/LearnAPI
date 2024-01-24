using LearnAPI.Application.Notificator;
using LearnAPI.Application.Services;
using LearnAPI.Domain.Interfaces.Repositories;
using LearnAPI.Application.Interfaces.Services;
using LearnAPI.Infra;
using LearnAPI.Infra.Repositories;

namespace LearnAPI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<LearnContext>();

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
