using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnAPI.Domain.Models;

namespace LearnAPI.Application.Interfaces.Services
{
    public interface IClassroomService: IDisposable
    {
        Task Get();
        Task Post(Classroom classroom);
        Task Update(Classroom classroom);
        Task Remove(Guid id);

    }
}
