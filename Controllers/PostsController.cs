using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        public readonly DatabaseContext _context;

        public PostsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.Posts.ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Search(string kelime)
        {
            var model = await _context.Posts.Where(p => p.Name.Contains(kelime)).ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            var model = await _context.Posts.FindAsync(id);
            return View(model);
        }
    }
}
