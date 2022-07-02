using System.ComponentModel.DataAnnotations;

namespace narayaniaesthetics.com.web.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Summary { get; set; }


        [MaxLength(2000)]
        public string Keywords { get; set; }

        public string BodyContent { get; set; }


        [MaxLength(100)]
        public string AuthorName { get; set; }


        public DateTime PublishedDate { get; set; }
    }
}
