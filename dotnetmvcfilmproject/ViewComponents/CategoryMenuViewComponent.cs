using dotnetmvcfilmproject.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmvcfilmproject.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);

        }
        
    }
}