using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The User Name is Required")]
        [MaxLength(100, ErrorMessage = "User Name is too long")]
        public string User_Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        [Required(ErrorMessage = "The content is Required")]
        public string Content { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
