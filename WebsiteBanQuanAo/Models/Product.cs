using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBanQuanAo.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public int CategoryProductID { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Size { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsBestSeller { get; set; }
        public bool? IsSale { get; set; }
        public int UnitlnStock { get; set; }
        public bool? IsActive { get; set; }
    }
}
