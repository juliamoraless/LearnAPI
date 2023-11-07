using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Interfaces.Services
{
    public interface IStudentService: IDisposable
    {
        Task Get();
        Task Post(Student student);
        Task Update(Student student);
        Task Remove(Guid id);
        
    }
}
