using AutoMapper;
using LearnAPI.Application.ViewModels.Student;
using LearnAPI.Domain.Models;

namespace LearnAPI.Application.Profiles;

public class StudentProfile: Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentListViewModel>()
            .ForMember(dst => dst.Classroom, map => map.MapFrom(src => src.Classroom.Name))
            .ReverseMap();
    }
}