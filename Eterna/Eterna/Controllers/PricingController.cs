using Eterna.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers;
public class PricingController : Controller
{
    private readonly AppDbContext _context;
    public PricingController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        return View();
    }
}