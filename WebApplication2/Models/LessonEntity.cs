namespace WebApplication2.Models
{
    public class LessonEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string LessonText { get; set; } = string.Empty;

        public Guid CourseId { get; set; }

        public CourseEntity? Course { get; set; }


    }
}
