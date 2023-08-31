using Eterna.DataAccessLayer;
using Eterna.ViewModels.AboutVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers;
public class AboutController : Controller
{
    private readonly AppDbContext _context;
    public AboutController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        AboutVM aboutVM = new AboutVM
        {
            Clients = await _context.Clients.Where(c => !c.IsDeleted).ToListAsync(),
            Testimonials = await _context.Testimonials.Where(t => !t.IsDeleted).ToListAsync()
        };
        return View(aboutVM);
    }
}