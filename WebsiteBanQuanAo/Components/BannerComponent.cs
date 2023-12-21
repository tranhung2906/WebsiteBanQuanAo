using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebsiteBanQuanAo.Models;

namespace WebsiteBanQuanAo.Components
{
    [ViewComponent(Name ="Banner")]
    public class BannerComponent : ViewComponent
    {
        private readonly DataContext _context;
        public BannerComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofBanner = (from b in _context.Banners
                                where (b.IsActive == true)
                                select b).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofBanner));
        }
    }
}
