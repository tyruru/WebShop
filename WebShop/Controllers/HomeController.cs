using System.Diagnostics;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using WebShop.Models;
using WebShop.Resources;

namespace WebShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // private readonly IStringLocalizer<Texts> _localizer;

    public HomeController(ILogger<HomeController> logger/*, IStringLocalizer<Texts> localizer*/)
    {
        _logger = logger;
        // _localizer = localizer;
    }

    public IActionResult Index()
    {
        // string t = _localizer["Title"].Value;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}