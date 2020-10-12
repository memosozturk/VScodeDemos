using System.Collections.Generic;
using System.Linq;

namespace dotnetmvcfilmproject.Models
{
    public class Repository
    {
        private static List<Movie> _movies=null;
        static Repository(){
            _movies =new List<Movie>()
            {
                new Movie(){Id=1,Name="Yeşil Yol",Description="Dram",Imageurl="1.jpg"},
                new Movie(){Id=2,Name="Hızlı ve Öfkeli 12",Description="Sonsuzluk",Imageurl="2.jpg"},
                new Movie(){Id=3,Name="Avatar",Description="İkincisi gelecek diye 10 senedir bekliyoruz.",Imageurl="3.jpg"},
                new Movie(){Id=4,Name="Yenilmezler",Description="Yaşasın Thanos Baba",Imageurl="4.jpg"},
                new Movie(){Id=5,Name="Instellar",Description="Uzay,Kara delik",Imageurl="5.jpg"}
            };
        }
        public static List<Movie> Movies{
            get{
                return _movies;
            }
        }
        public static void AddMovie(Movie Entity)
        {
            _movies.Add(Entity);
        }
        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i=>i.Id==id);
        }
    }
}