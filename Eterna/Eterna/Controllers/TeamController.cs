using Eterna.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers;
public class TeamController : Controller
{
    private readonly AppDbContext _context;
    public TeamController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _context.Employees.Include(e => e.Position).Where(e => !e.IsDeleted).ToListAsync());
    }
}