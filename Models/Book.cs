namespace API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly PublishDate { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public int CategoryId { get; set; }
    }
}
