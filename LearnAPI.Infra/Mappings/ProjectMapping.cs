using LearnAPI.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Infra.Mappings
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.Property(m => m.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1000);

            builder.HasOne(p => p.Mentor)
                .WithMany(m => m.Projects)
                .HasForeignKey(p => p.MentorId);

            builder.HasOne(p => p.Classroom)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClassroomId);

            builder.HasMany(p => p.Students)
                .WithOne(s => s.Project)
                .HasForeignKey(s => s.ProjectId);
        }
    }
}
