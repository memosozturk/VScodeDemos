using dotnetmvcfilmproject.Data;
using dotnetmvcfilmproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmvcfilmproject.Controllers
{
    public class HomeController:Controller
    {
    
    public IActionResult Index()
    {
        //
        return View();
    }

    public IActionResult Details(int id){
        return View(MovieRepository.GetById(id));
    }
    public IActionResult Contact()
    {
        return View();
    }
    
    }
}