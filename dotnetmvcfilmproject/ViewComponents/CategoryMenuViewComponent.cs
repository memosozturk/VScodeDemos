using dotnetmvcfilmproject.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmvcfilmproject.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["Action"].ToString()=="Index")
            ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Categories);

        }
        
    }
}