using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Domain.Models
{
    public class BaseEntity
    {
        protected BaseEntity() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
