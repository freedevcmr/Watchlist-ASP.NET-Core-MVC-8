using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Watchlist.Models;

namespace Watchlist.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //pss: Bonjour#123
            //une fois que l'utilisateur se connecte on le redirige vers sa liste de films 
            if(User.Identity.IsAuthenticated){
                return RedirectToAction("Index", "ListeFilms");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
