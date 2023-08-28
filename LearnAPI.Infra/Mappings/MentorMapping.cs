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
    public class MentorMapping : IEntityTypeConfiguration<Mentor>
    {
        public void Configure(EntityTypeBuilder<Mentor> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.HasOne(m => m.Classroom)
                .WithMany(c => c.Mentors)
                .HasForeignKey(m => m.ClassroomId);

            builder.HasMany(m => m.Projects)
                 .WithOne(p => p.Mentor)
                 .HasForeignKey(p => p.MentorId);

            builder.HasMany(m => m.Students)
                 .WithOne(s => s.Mentor)
                 .HasForeignKey(s => s.MentorId);
        }
    }
}
