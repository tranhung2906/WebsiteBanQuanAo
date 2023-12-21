using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBanQuanAo.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int BannerID { get; set; }
        public string? Title { get; set; }
        public string? Images { get; set; }
        public bool? IsActive { get; set; }
    }
}
