using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHangOnline_Final.Models.EF
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Slug { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool Deleted { get; set; }
        public DateTime UpdateOnUtc { get; set; }

    }
}
