using LearnAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Infra.Mappings
{
    public class ClassroomMapping: IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.Property(x => x.Turno)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(10);

            builder.HasMany(c => c.Students)
                .WithOne(s => s.Classroom)
                .HasForeignKey(s => s.ClassroomId);

            builder.HasMany(c => c.Projects)
                .WithOne(s => s.Classroom)
                .HasForeignKey(s => s.ClassroomId);

            builder.HasMany(c => c.Mentors)
                .WithOne(s => s.Classroom)
                .HasForeignKey(s => s.ClassroomId);
        }
    }
}
