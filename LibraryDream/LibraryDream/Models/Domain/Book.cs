using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryDream.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Isbn { get; set; }
        [Required]
        public int TotalPages { get; set; }

        public virtual IEnumerable<Genre> Genres { get; set; }
        public virtual Author Author { get; set; }

    }
}
