namespace API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } // One to many relationship between Category and Book
    }
}
