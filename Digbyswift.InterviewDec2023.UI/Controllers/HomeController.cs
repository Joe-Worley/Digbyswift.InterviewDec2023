using Microsoft.AspNetCore.Mvc;

namespace Digbyswift.InterviewDec2023.UI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}