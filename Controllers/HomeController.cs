using Blog.Data;
using Blog.Entites;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Posts.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("hakkimda")]
        public IActionResult About()
        {
            return View();
        }

        [Route("iletisim")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost, Route("iletisim")]
        public IActionResult ContactUs(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                TempData["Message"] = "<div class='alert alert-success' >Mesajýnýz Gönderildi</div>";
                return RedirectToAction("ContactUs");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Hata oluþtu!");
            }
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
