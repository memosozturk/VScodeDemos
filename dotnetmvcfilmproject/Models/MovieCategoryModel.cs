using System.Collections.Generic;
namespace dotnetmvcfilmproject.Models
{
    public class MovieCategoryModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}