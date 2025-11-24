using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The content is Required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "The author is Required")]
        [MaxLength(100, ErrorMessage = "Author name is too long")]
        public string Author { get; set; }
        public string ImagePath { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
