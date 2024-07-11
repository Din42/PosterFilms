using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc;
using PosterFilms.Model;
//обработка запросов
namespace PosterFilms.Controllers
{
    public class MainController : Controller        
    {
        private readonly Info _info;

        public MainController()
        {
            _info = new Info();
        }

        public IActionResult Index()
        {
            return View(_info.Movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _info.GetMovieById(id);
            if(movie == null)
            {
                return NotFound();
            }
            else
            {
                return View(movie);
            }
        }

    }
}
