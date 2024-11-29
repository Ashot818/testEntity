using Microsoft.EntityFrameworkCore;
using WebApplication2.Configurations;
using WebApplication2.Models;

namespace WebApplication2
{
    public class LearningDbContext(DbContextOptions<LearningDbContext> options) 
        : DbContext(options)    
    {
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<LessonEntity> Lessons { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfigurations());
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            modelBuilder.ApplyConfiguration(new AuthorConfigurations());
            modelBuilder.ApplyConfiguration(new LessonConfigurations());

            base.OnModelCreating(modelBuilder);
        }

    }
}
