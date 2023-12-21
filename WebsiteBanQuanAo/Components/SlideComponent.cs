using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteBanQuanAo.Models;
namespace WebsiteBanQuanAo.Components
{
    [ViewComponent(Name ="Slide")]
    public class SlideComponent : ViewComponent
    {
        private readonly DataContext _context;
        public SlideComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofSlide  = (from s in _context.Slides
                                where (s.Status == 1)
                                select s).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofSlide));
        }
    }
}
