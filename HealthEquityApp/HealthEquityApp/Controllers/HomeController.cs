using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HealthEquityApp.Models;
using HealthEquityApp.Dal;

namespace HealthEquityApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICarService _carService;

    public HomeController(ILogger<HomeController> logger, ICarService carService)
    {
        _logger = logger;
        _carService = carService;
    }

    public async Task<IActionResult> Index()
    {
        var carList = await _carService.GetAllAsync();
        return View(carList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

