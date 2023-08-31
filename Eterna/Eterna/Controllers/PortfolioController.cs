using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers;
public class PortfolioController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }
    public async Task<IActionResult> Details()
    {
        return View();
    }
}