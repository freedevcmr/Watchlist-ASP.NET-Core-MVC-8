
using Microsoft.AspNetCore.Identity;

namespace Watchlist.Data
{
    public class Utilisateur : IdentityUser
    {


        public string Prenom { get; set; }
        public virtual ICollection<FilmUtilisateur> ListeFilms { get; set; }

        /// mise en place du construteur 
        public Utilisateur() :base() 
        {
            this.ListeFilms =new HashSet<FilmUtilisateur>();
        }

       

    }
}
