using Eterna.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Single()
        {
            return View();
        }
    }
}