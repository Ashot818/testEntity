namespace WebApplication2
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public int? FKPublisherId { get; set; }
    }
}
