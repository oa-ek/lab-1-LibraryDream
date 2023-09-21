using System.ComponentModel.DataAnnotations;

namespace LibraryDream.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
