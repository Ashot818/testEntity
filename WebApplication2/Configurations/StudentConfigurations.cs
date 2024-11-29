using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.
                HasKey(c => c.Id);

            builder
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);
        }
    }
}
