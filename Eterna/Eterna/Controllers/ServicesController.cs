using Eterna.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers;
public class ServicesController : Controller
{
    private readonly AppDbContext _context;
    public ServicesController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _context.Services.Where(s => !s.IsDeleted).ToListAsync());
    }
}