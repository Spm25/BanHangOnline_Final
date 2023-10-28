using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanHangOnline_Final.Models.EF
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        //public int CategoryId { get; set; }
        public string ShortDes { get; set; }
        public string FullDescription { get; set; }
        public float Price { get; set; }
        public float PriceDiscount { get; set; }
        public int? TypeId { get; set; }
        public string Slug { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public bool Deleted { get; set; }
        public bool ShowOnHomePage { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime updatedOnUtc { get; set; }
        public Brand Brand { get; set; }

    }
}
