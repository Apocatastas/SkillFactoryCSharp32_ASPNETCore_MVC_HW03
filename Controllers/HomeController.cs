using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Repositories;

namespace MvcStartApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBlogRepository _repo;

    public HomeController(ILogger<HomeController> logger, IBlogRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    public async Task <IActionResult> Index()
    { 
        return View();
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
    public async Task<IActionResult> Authors()
    {
        var authors = await _repo.GetUsers();
        return View(authors);
    }
}
