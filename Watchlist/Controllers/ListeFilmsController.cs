using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Watchlist.Data;
using Watchlist.Models;


namespace Watchlist.Controllers
{
    public class ListeFilmsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Utilisateur> _gestionnaire;

        public ListeFilmsController(ApplicationDbContext context, UserManager<Utilisateur> gestionnaire )
        {
            _context = context;
            _gestionnaire = gestionnaire;
        }

        private Task<Utilisateur> GetCurrentUserAsync() => _gestionnaire.GetUserAsync(HttpContext.User);

        [HttpGet]
        public async Task<string> RecupererIdUtilisateurCourant()
        {
            Utilisateur utilisateur = await GetCurrentUserAsync();
            return utilisateur?.Id;
        }
        public async Task<IActionResult> Index()
        {
            var id = await RecupererIdUtilisateurCourant();

            var filmsUtilisateur = _context.FilmsUtilisateur.Where(x => x.IdUtilisateur == id);
            var modele = filmsUtilisateur.Select( x => new ModeleVueFilm
            {
                IdFilm = x.IdFilm, 
                Titre = x.Film.Titre,
                Annee = x.Film.Annee,
                Vu =x.Vu,
                presentDansListe = true, 
                Note = x.Note
            }).ToList();

            return View(modele);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Create()
        {

            return "je suis le controller listefilmsController";

           
            
        }



    }
}
