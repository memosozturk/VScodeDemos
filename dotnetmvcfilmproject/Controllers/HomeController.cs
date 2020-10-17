using dotnetmvcfilmproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmvcfilmproject.Controllers
{
    public class HomeController:Controller
    {
    
    public IActionResult Index()
    {
        return View(Repository.Movies);
    }
    public IActionResult Contact()
    {
        return View();
    }
    
    }
}