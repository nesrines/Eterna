using Eterna.DataAccessLayer;
using Eterna.ViewModels.HomeVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers;
public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        HomeVM homeVM = new HomeVM
        {
            Slides = await _context.Slides.Where(s => !s.IsDeleted).ToListAsync(),
            Features = await _context.Features.Where(f => !f.IsDeleted).ToListAsync(),
            Services = await _context.Services.Where(t => !t.IsDeleted).ToListAsync(),
            Clients = await _context.Clients.Where(c => !c.IsDeleted).ToListAsync()
        };
        return View(homeVM);
    }
}