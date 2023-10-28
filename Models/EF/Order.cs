using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanHangOnline_Final.Models.EF
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("User")]
        public float Price { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public Product Product { get; set; }
    }
}
