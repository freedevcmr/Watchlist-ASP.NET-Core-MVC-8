﻿


namespace Watchlist.Data
{
    public class Utilisateur : Microsoft.AspNetCore.Identity.IdentityUser
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
