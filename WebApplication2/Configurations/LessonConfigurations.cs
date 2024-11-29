using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class LessonConfigurations : IEntityTypeConfiguration<LessonEntity>
    {
        public void Configure(EntityTypeBuilder<LessonEntity> builder)
        {
            builder.
                HasKey(c => c.Id);

            builder
                .HasOne(l => l.Course)
                  .WithMany(c => c.Lessons)
                  .HasForeignKey(l => l.CourseId);
        }
    } 
}
