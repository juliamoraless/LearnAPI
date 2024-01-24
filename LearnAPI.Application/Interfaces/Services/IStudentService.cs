using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnAPI.Application.ViewModels.Student;

namespace LearnAPI.Application.Interfaces.Services
{
    public interface IStudentService: IDisposable
    {
        Task<IEnumerable<StudentListViewModel>> GetStudents();
        Task Post(Student student);
        Task Update(Student student);
        Task Remove(Guid id);
        
    }
}
