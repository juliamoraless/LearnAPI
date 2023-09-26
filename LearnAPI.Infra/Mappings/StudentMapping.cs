using LearnAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Infra.Mappings
{
    public class StudentMapping: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.Property(s => s.Document)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(12); 

            builder.HasOne(s => s.Classroom)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassroomId);

            builder.HasOne(s => s.Project)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.ProjectId);

            builder.HasOne(s => s.Mentor)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.MentorId);
        }
    }
}
