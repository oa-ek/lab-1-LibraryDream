using System.ComponentModel.DataAnnotations;

namespace LibraryDream.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
