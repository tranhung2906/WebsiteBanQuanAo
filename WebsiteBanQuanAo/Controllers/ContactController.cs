using WebsiteBanQuanAo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace WebsiteBanQuanAo.Controllers
{
	public class ContactController : Controller
	{
		private readonly DataContext _context;
		public ContactController(DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public bool Create(string c_name, string c_email,string c_text)
		{
			try
			{
				Contact contact = new Contact();
				contact.Name = c_name;
				contact.Email = c_email;
				contact.Message = c_text;
				_context.Add(contact);
				_context.SaveChanges();

				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
