using dotnetmvcfilmproject.Data;
using dotnetmvcfilmproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmvcfilmproject.Controllers
{
    public class HomeController:Controller
    {
    
    public IActionResult Index()
    {
        MovieCategoryModel model=new MovieCategoryModel();
        model.Categories=CategoryRepository.Categories;
        model.Movies=MovieRepository.Movies;

        //
        return View(model);
    }

    public IActionResult Details(int id){
        MovieCategoryModel model=new MovieCategoryModel();
        model.Categories=CategoryRepository.Categories;
        model.Movie=MovieRepository.GetById(id);
        return View(model);
    }
    public IActionResult Contact()
    {
        return View();
    }
    
    }
}