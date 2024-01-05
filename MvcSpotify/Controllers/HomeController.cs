using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    // 
    // GET: /Home/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Home//Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name = "User", int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    // GET: /Home/Privacy/
    public IActionResult Privacy()
    {
        return View();
    }
}