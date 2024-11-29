using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class AuthorConfigurations : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.
                HasKey(a => a.Id);

            builder.
                HasOne(a => a.Course)
                .WithOne(c => c.Author)
                .HasForeignKey<AuthorEntity>(a => a.CourseId);

        }
    } 
}
