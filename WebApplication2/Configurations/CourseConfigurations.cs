using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<CourseEntity>
    {
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {
            builder.
                HasKey(c => c.Id);

            builder.
                HasOne(c => c.Author)
                .WithOne(c => c.Course)
                .HasForeignKey<CourseEntity>(c => c.AuthorId);
            

            builder
                .HasMany(c=>c.Lessons)
                .WithOne(l=> l.Course)
                .HasForeignKey(l=>l.CourseId);


            builder.
                HasMany(c => c.Students)
                .WithMany(s => s.Courses);


        }
    }
}
