using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBanQuanAo.Models
{
    [Table("Slide")]
    public class Slide
    {
        [Key]
        public int SlideID { get; set; }
        public string? Title { get; set; }
        public string? AbStract { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public string? Link { get; set; }
        public int Status { get; set; }
    }
}
